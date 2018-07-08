using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cal_And_Utills_To_Degree_Points;

namespace Data_Interface
{
    public partial class StatisticsForm : Form
    {
        public StatisticsForm()
        {
            InitializeComponent();
        }

        internal void LoadData(Dictionary<string, CalculateAvg> yearsAvg)
        {
            foreach (KeyValuePair<string, CalculateAvg> yearAvg in yearsAvg)
            {
                ListViewItem lvi = new ListViewItem(yearAvg.Key);
                lvi.SubItems.Add( yearAvg.Value.ToString());

                avgsListView.Items.Add(lvi);

                int listViewCount = avgsListView.Items.Count;

                if (listViewCount % 2 == 0)
                {
                    avgsListView.Items[listViewCount - 1].BackColor = Color.LightGray;
                }
            }          
        }        
    }
}
