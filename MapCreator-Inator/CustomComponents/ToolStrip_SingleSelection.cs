using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapCreator_Inator.CustomComponents
{
    class ToolStrip_SingleSelection : ToolStrip
    {
        public int selected_tool = -1;
        public ToolStrip_SingleSelection()
        {
            this.ItemClicked += new ToolStripItemClickedEventHandler(this.this_ItemClicked);
        }

        private void this_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.GetType() != typeof(ToolStripButton)) return;
            ToolStripButton clicked_button = e.ClickedItem as ToolStripButton;
            for (int i = 0; i < this.Items.Count; i++)
            {
                ToolStripItem item = this.Items[i];
                if(item.GetType() == typeof(ToolStripButton))
                {
                    ToolStripButton button = item as ToolStripButton;
                    if (button == clicked_button)
                    {
                        if (selected_tool == -1 || selected_tool != i)
                        {
                            selected_tool = i;
                        }
                        else
                        {
                            selected_tool = -1;
                        }
                    }
                    else
                    {
                        button.Checked = false;
                    }
                }
            }
        }
    }
}
