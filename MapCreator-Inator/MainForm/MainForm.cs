using MapCreator_Inator.CustomComponents;
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
        private Point last_click, last_mouse;

        private int curr_log_scale;
        private int N = 1000;
        private int octaves = 12;

        private MapManager map_manager;

        public MainForm()
        {
            InitializeComponent();
            initComponents2();

            map_manager = new MapManager(N);
            seed_text_box.Text = map_manager.randomize(octaves).ToString();

            resizeWindow();
            this.Invalidate();
        }

        private void resizeWindow()
        {
            info_panel.Size = new Size(info_panel.Width, this.Size.Height - 84);

            int max_width = this.Size.Width - info_panel.Width - maps_tab_menu.Size.Width - 47;
            int max_height = this.Size.Height - 84;
            int min = Math.Min(max_width, max_height);
            map_picture_box.Size = new Size(min, min);
            map_picture_box.Location = new Point((max_width - min) / 2 + info_panel.Location.X + info_panel.Width + 6, (max_height - min) / 2 + 33);

            maps_tab_menu.Size = new Size(maps_tab_menu.Width, this.Size.Height - 84);
            maps_tab_menu.Location = new Point(this.Size.Width - maps_tab_menu.Width - 28, maps_tab_menu.Location.Y);

            updateMap();
        }

        private void initComponents2()
        {
            this.DoubleBuffered = true;
            nodes_numericUD.Value = N;
            octaves_numericUD.Value = octaves;
            height_brush_width_combobox.SelectedIndex = 3;
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
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
            */
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
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
            */
        }

        private void map_picture_box_MouseMove(object sender, MouseEventArgs e)
        {
            int curr_x, curr_y, size, dx = 0, dy = 0;
            if (hd_checkbox.Checked)
            {
                curr_x = e.X;
                curr_y = e.Y;
                size = map_picture_box.Width;
            }
            else
            {
                curr_x = e.X / 2;
                curr_y = e.Y / 2;
                size = map_picture_box.Width/2;
            }
            if (last_click.X != -1 && last_click.Y != -1)
            {
                dx = last_click.X - curr_x;
                dy = last_click.Y - curr_y;
            }
            float radius = int.Parse(height_brush_width_combobox.SelectedItem as string) / 2f;
            float inner_radius = radius * (float)height_brush_hardness_numericUD.Value / 100f;
            if (e.Button == MouseButtons.Left)
            {
                switch (maps_tab_menu.SelectedIndex)
                {
                    case 0:
                        switch (height_tool_strip.selected_tool)
                        {
                            case 0:
                                map_manager.changeOffset(dx, dy);
                                updateMap();
                                break;
                            case 1:
                                map_manager.changeAtPos(0.005f, size, curr_x, curr_y, inner_radius, radius);
                                updateMap();
                                break;
                            case 2:
                                map_manager.changeAtPos(-0.005f, size, curr_x, curr_y, inner_radius, radius);
                                updateMap();
                                break;
                            case 3:
                                map_manager.levelAtPos(0.1f, size, curr_x, curr_y, inner_radius, radius);
                                updateMap();
                                break;
                            case 4:
                                map_manager.levelAtPos(-0.01f, size, curr_x, curr_y, inner_radius, radius);
                                updateMap();
                                break;
                        }
                        break;
                }
                if (hd_checkbox.Checked)
                {
                    last_click = e.Location;
                }
                else
                {
                    last_click = new Point(e.Location.X / 2, e.Location.Y / 2);
                }
            }
            else if(e.Button == MouseButtons.Middle)
            {
                map_manager.changeOffset(dx, dy);
                updateMap();
                if (hd_checkbox.Checked)
                {
                    last_click = e.Location;
                }
                else
                {
                    last_click = new Point(e.Location.X / 2, e.Location.Y / 2);
                }
            }
            else
            {
                last_click = new Point(-1, -1);
            }
            last_mouse = e.Location;
            map_picture_box.Refresh();
        }

        private void map_picture_box_Wheel(object sender, MouseEventArgs e)
        {
            int pos_x, pos_y;
            if (hd_checkbox.Checked)
            {
                pos_x = e.X;
                pos_y = e.Y;
            }
            else
            {
                pos_x = e.X / 2;
                pos_y = e.Y / 2;
            }

            int size = map_picture_box.Width;
            if (pos_x >= 0 && pos_x <= size - 1 && pos_y >= 0 && pos_y <= size - 1)
            {
                float ds = (float)Math.Pow(Math.E, e.Delta / 1000f);
                curr_log_scale = (int)(Math.Log(map_manager.changeScaleFixingPoint(ds, pos_x, pos_y)) * 10f);

                updateMap();

                scale_track_bar.Value = curr_log_scale;
            }
        }

        private void map_picture_box_Paint(object sender, PaintEventArgs e)
        {
            switch (maps_tab_menu.SelectedIndex)
            {
                case 0:
                    switch (height_tool_strip.selected_tool)
                    {
                        case 0:
                            if(map_picture_box.Cursor != Cursors.Hand) map_picture_box.Cursor = Cursors.Hand;
                            break;
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                            if(map_picture_box.Cursor != Cursors.Cross) map_picture_box.Cursor = Cursors.Cross;
                            Pen dotted_line = new Pen(Color.Black);
                            int width = int.Parse(height_brush_width_combobox.SelectedItem as string);
                            float radius = map_picture_box.Width * map_manager.getScale() * width / (map_manager.getSize()*2);
                            float inner_radius = radius * (float)height_brush_hardness_numericUD.Value / 100f;
                            e.Graphics.DrawEllipse(dotted_line, last_mouse.X - inner_radius, last_mouse.Y - inner_radius, inner_radius * 2, inner_radius * 2);
                            dotted_line.DashPattern = new float[] { 6f, 6f };
                            e.Graphics.DrawEllipse(dotted_line, last_mouse.X - radius, last_mouse.Y - radius, radius * 2, radius * 2);
                            break;
                        default:
                            if (map_picture_box.Cursor != Cursors.Default) map_picture_box.Cursor = Cursors.Default;
                            break;
                    }
                    break;
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            resizeWindow();
        }
    }
}
