using System.Drawing;
using System.Windows.Forms;


namespace Logic_And_Settings
{
    public static class UtillsColors
    {
        public static void RowColor(ListViewItem i_ListViewRowItem, int i_RowNumber)
        {


            if (i_RowNumber % 2 != 0)
            {
                i_ListViewRowItem.BackColor = Color.Silver; // Color.LightBlue ; 
                i_ListViewRowItem.ForeColor = Color.White;
            }
            else
            {
                i_ListViewRowItem.BackColor = Color.White;
                i_ListViewRowItem.ForeColor = Color.Black;
            }

            //i_ListViewRowItem.BackColor = Color.White;
            //i_ListViewRowItem.ForeColor = Color.Black;
        }
    }
}