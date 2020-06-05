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
        private void maps_tab_menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateMap();
        }
    }
}
