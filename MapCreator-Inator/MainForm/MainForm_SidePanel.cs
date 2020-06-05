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
    public partial class MainForm
    {
        private void scale_track_bar_ValueChanged(object sender, EventArgs e)
        {
            if (scale_track_bar.Value != curr_log_scale)
            {
                int size = map_picture_box.Width;

                float scale = (float)Math.Pow(Math.E, scale_track_bar.Value / 10f);
                curr_log_scale = (int)(Math.Log(map_manager.setScaleFixingPoint(scale, size / 2, size / 2)) * 10f);

                updateMap();

                scale_track_bar.Value = curr_log_scale;
            }
        }

        private void generate_button_Click(object sender, EventArgs e)
        {
            if (random_seed_check_box.Checked)
            {
                map_manager.resetMap(N);
                seed_text_box.Text = map_manager.randomize(octaves).ToString();
                updateMap();
            }
            else
            {
                long seed;
                if (long.TryParse(seed_text_box.Text, out seed))
                {
                    map_manager.resetMap(N);
                    map_manager.randomize(octaves, seed);
                    updateMap();
                }
                else
                {
                    map_manager.resetMap(N);
                    seed_text_box.Text = map_manager.randomize(octaves).ToString();
                    updateMap();
                }
            }
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
        private void hd_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            map_manager.unhdOffset(hd_checkbox.Checked);
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
    }
}
