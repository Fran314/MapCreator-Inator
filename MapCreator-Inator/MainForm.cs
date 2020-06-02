using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapCreator_Inator
{
    public partial class MainForm : Form
    {
        private int last_x, last_y;
        private int curr_log_scale;
        private int N = 200;
        private int octaves = 12;
        private Mesh map;
        private MapRenderer map_renderer;
        private List<Color[]> colormaps;

        public MainForm()
        {
            InitializeComponent();
            initComponents2();

            initColormaps();

            map = new Mesh(N);
            seed_text_box.Text = map.randomize(octaves).ToString();
            map_renderer = new MapRenderer(map);

            resizeWindow();
            this.Invalidate();
        }

        private void resizeWindow()
        {
            info_panel.Size = new Size(info_panel.Width, this.Size.Height - 84);

            maps_tab_menu.Size = new Size(this.Size.Width - maps_tab_menu.Location.X - 28, maps_tab_menu.Size.Height);
            maps_tab_menu.Location = new Point(maps_tab_menu.Location.X, this.Size.Height - maps_tab_menu.Size.Height - 51);

            int min = Math.Min(maps_tab_menu.Size.Width - 21, maps_tab_menu.Location.Y - 39);
            map_picture_box.Size = new Size(min, min);
            map_picture_box.Location = new Point((maps_tab_menu.Size.Width - 21 - min) / 2 + 227, (maps_tab_menu.Location.Y - 39 - min) / 2 + 33);

            updateMap();
        }

        private void updateMap()
        {
            int size = map_picture_box.Width;
            if(size > 0)
            {
                int gizmos = 0;
                if (show_nodes_check_box.Checked) gizmos |= MapRenderer.NODES;
                if (show_distance_check_box.Checked) gizmos |= MapRenderer.DISTANCE;
                Image to_dispose = null;
                if (map_picture_box.Image == null) map_picture_box.Image = new Bitmap(size, size, PixelFormat.Format24bppRgb);
                else if (map_picture_box.Image.Width != size)
                {
                    to_dispose = map_picture_box.Image;
                    map_picture_box.Image = new Bitmap(size, size, PixelFormat.Format24bppRgb);
                }
                map_renderer.updateImage(map_picture_box.Image, colormaps[maps_tab_menu.SelectedIndex], gizmos, (int)distance_numericUD.Value);
                map_picture_box.Refresh();
                if (to_dispose != null) to_dispose.Dispose();
            }
        }

        private void scale_track_bar_ValueChanged(object sender, EventArgs e)
        {
            if(scale_track_bar.Value != curr_log_scale)
            {
                int size = map_picture_box.Width;

                float scale = (float)Math.Pow(Math.E, scale_track_bar.Value / 10f);
                curr_log_scale = (int)(Math.Log(map_renderer.setScaleFixingPoint(scale, size / 2, size / 2)) * 10f);

                updateMap();

                scale_track_bar.Value = curr_log_scale;
            }
        }

        private void height_map_panel_Wheel(object sender, MouseEventArgs e)
        {
            int pos_x = e.X, pos_y = e.Y;

            int size = map_picture_box.Width;
            pos_x = pos_x - (map_picture_box.Width - size) / 2;
            pos_y = pos_y - (map_picture_box.Height - size) / 2;
            if (pos_x >= 0 && pos_x <= size - 1 && pos_y >= 0 && pos_y <= size - 1)
            {
                float ds = (float)Math.Pow(Math.E, e.Delta / 1000f);

                curr_log_scale = (int)(Math.Log(map_renderer.changeScaleFixingPoint(ds, pos_x, pos_y)) * 10f);

                updateMap();

                scale_track_bar.Value = curr_log_scale;
            }
        }

        private void height_picture_box_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int curr_x = e.X;
                int curr_y = e.Y;
                if (last_x != -1 && last_y != -1)
                {
                    int dx = last_x - curr_x;
                    int dy = last_y - curr_y;

                    map_renderer.changeOffset(dx, dy);

                    updateMap();
                }
                last_x = curr_x;
                last_y = curr_y;
            }
            else
            {
                last_x = -1;
                last_y = -1;
            }
        }

        private void randomize_button_Click(object sender, EventArgs e)
        {
            if (random_seed_check_box.Checked)
            {
                map.reset(N);
                seed_text_box.Text = map.randomize(octaves).ToString();
                updateMap();
            }
            else
            {
                long seed;
                if(long.TryParse(seed_text_box.Text, out seed))
                {
                    map.reset(N);
                    map.randomize(octaves, seed);
                    updateMap();
                }
                else
                {
                    map.reset(N);
                    seed_text_box.Text = map.randomize(octaves).ToString();
                    updateMap();
                }
            }
        }

        private void initComponents2()
        {
            nodes_numericUD.Value = N;
            octaves_numericUD.Value = octaves;
        }

        private void initColormaps()
        {
            colormaps = new List<Color[]>();

            Color[] height_colormap = new Color[256];
            for (int i = 0; i < 128; i++)
            {
                float t = i / 128f;
                height_colormap[i] = Color.FromArgb((int)(42 * (1f - t) + 94 * t), (int)(44 * (1f - t) + 79 * t), (int)(107 * (1f - t) + 162 * t));
            }
            for (int i = 128; i < 192; i++)
            {
                float t = (i - 128f) / (192f - 128f);
                height_colormap[i] = Color.FromArgb((int)(99 * (1f - t) + 246 * t), (int)(184 * (1f - t) + 250 * t), (int)(170 * (1f - t) + 174 * t));
            }
            for (int i = 192; i < 256; i++)
            {
                float t = (i - 192f) / (256f - 192f);
                height_colormap[i] = Color.FromArgb((int)(246 * (1f - t) + 221 * t), (int)(250 * (1f - t) + 75 * t), (int)(174 * (1f - t) + 74 * t));
            }
            colormaps.Add(height_colormap);

            Color[] political_colormap = new Color[2];
            political_colormap[0] = Color.DimGray;
            political_colormap[1] = Color.Gainsboro;
            colormaps.Add(political_colormap);
        }

        private void maps_tab_menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateMap();
        }
        private void random_seed_check_box_CheckedChanged(object sender, EventArgs e)
        {
            seed_text_box.Enabled = !random_seed_check_box.Checked;
        }
        private void check_box_CheckedChanged(object sender, EventArgs e)
        {
            updateMap();
        }
        private void distance_numericUD_ValueChanged(object sender, EventArgs e)
        {
            updateMap();
        }
        private void octaves_numericUD_ValueChanged(object sender, EventArgs e)
        {
            octaves = (int)octaves_numericUD.Value;
        }
        private void nodes_numericUD_ValueChanged(object sender, EventArgs e)
        {
            N = (int)nodes_numericUD.Value;
        }
        private void seed_text_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '-') && (((sender as TextBox).Text.IndexOf('-') > -1) || ((sender as TextBox).SelectionStart > 0)))
            {
                e.Handled = true;
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Directory.GetCurrentDirectory();
            ofd.Filter = "map files (*.mci)|*mci";
            DialogResult result = ofd.ShowDialog();

            if (result == DialogResult.OK)
            {
                using (FileStream file = File.OpenRead(ofd.FileName))
                {
                    using (BinaryReader reader = new BinaryReader(file))
                    {
                        N = (int)Math.Sqrt(file.Length / 4);
                        scale_track_bar.Focus();    // Just put the focus on something that isn't nodes_numericUD so that
                                                    // it can update the value
                        nodes_numericUD.Value = N;
                        nodes_numericUD.Invalidate();
                        map.reset(N);
                        for (int i = 0; i < N * N; i++)
                        {
                            map.setNode(i, reader.ReadSingle());
                        }
                        updateMap();
                    }
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog ofd = new SaveFileDialog();
            ofd.InitialDirectory = Directory.GetCurrentDirectory();
            ofd.Filter = "map files (*.mci)|*mci";
            DialogResult result = ofd.ShowDialog();

            if (result == DialogResult.OK)
            {
                using (FileStream file = File.Create(ofd.FileName))
                {
                    using (BinaryWriter writer = new BinaryWriter(file))
                    {
                        foreach (float value in map.getMesh())
                        {
                            writer.Write(value);
                        }
                    }
                }
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            resizeWindow();
        }
    }
}
