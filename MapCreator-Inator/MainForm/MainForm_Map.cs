using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        private void updateMap()
        {
            int size = map_picture_box.Width;
            if (size > 0)
            {
                int gizmos = 0;
                if (show_nodes_check_box.Checked) gizmos |= MapRenderer.NODES;
                if (show_distance_check_box.Checked) gizmos |= MapRenderer.DISTANCE;
                Image to_dispose = map_picture_box.Image;
                if(hd_checkbox.Checked)
                    map_picture_box.Image = map_manager.getImage(size, maps_tab_menu.SelectedIndex, gizmos, (int)distance_numericUD.Value);
                else
                    map_picture_box.Image = map_manager.getImage(size / 2, maps_tab_menu.SelectedIndex, gizmos, (int)distance_numericUD.Value);
                map_picture_box.Refresh();
                if (to_dispose != null) to_dispose.Dispose();
            }
        }
    }
}
