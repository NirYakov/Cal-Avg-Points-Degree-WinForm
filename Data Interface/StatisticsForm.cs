﻿using System;
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

        public CalculateAvg CalAverageStats { get; internal set; }


        internal void LoadData(Dictionary<string, CalculateAvg> yearsAvg)
        {
            avgsListView.Items.Clear();

            foreach (KeyValuePair<string, CalculateAvg> yearAvg in yearsAvg)
            {
                ListViewItem lvi = new ListViewItem(yearAvg.Key);
                lvi.SubItems.Add(yearAvg.Value.ToString());

                avgsListView.Items.Add(lvi);

                int listViewCount = avgsListView.Items.Count;

                if (listViewCount % 2 == 0)
                {
                    avgsListView.Items[listViewCount - 1].BackColor = Color.LightGray;
                }
            }

            float AvrgTotal = CalAverageStats.AverageTotal;
            updateAllMarkPointsData(AvrgTotal);
            numericUpDown1.Minimum = Convert.ToDecimal(AvrgTotal);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            float mark = Convert.ToSingle(numericUpDown1.Value);
            updateAllMarkPointsData(mark);
        }

        private void updateAllMarkPointsData(float i_Mark)
        {
            float points3 = CalAverageStats.ReachAvrg(i_Mark, 3);
            float points4 = CalAverageStats.ReachAvrg(i_Mark, 4);
            float points5 = CalAverageStats.ReachAvrg(i_Mark, 5);

            string myFormatBase = "{0:0}";

            if (points5 > 100)
            {
                points3Label.ForeColor = points4Label.ForeColor = points5Label.ForeColor = Color.Red;
            }
            else
            {
                points5Label.ForeColor = Color.Black;

                if (points4 > 100)
                {
                    points4Label.ForeColor = Color.Red;
                }
                else
                {
                    points4Label.ForeColor = SystemColors.Highlight;

                    if (points3 > 100)
                    {
                        points3Label.ForeColor = Color.Red;
                    }
                    else
                    {
                        points3Label.ForeColor = Color.Black;
                    }
                }
            }

            points3Label.Text = string.Format(myFormatBase, points3);
            points4Label.Text = string.Format(myFormatBase, points4);
            points5Label.Text = string.Format(myFormatBase, points5);

            if (checkBox1.CheckState == CheckState.Checked)
            {
                EventArgs e = new EventArgs();
                numericUpDown2_ValueChanged(myFormatBase, e);
            }

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = SystemColors.Highlight;
            button1.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
            button1.ForeColor = Color.Black;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            float points = Convert.ToSingle(numericUpDown2.Value);
            float mark = Convert.ToSingle(numericUpDown1.Value);
            float markNeeded = CalAverageStats.ReachAvrg(mark, points);

            if (markNeeded > 100)
            {
                label3.ForeColor = Color.Red;
            }
            else
            {
                label3.ForeColor = Color.White;
            }

            label3.Text = string.Format("{0:0}", markNeeded);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                numericUpDown2.Visible = label3.Visible = true;
            }
            else
            {
                numericUpDown2.Visible = label3.Visible = false;
            }
        }
    }
}
