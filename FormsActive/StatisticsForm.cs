using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Logic_And_Settings;

namespace FormsActive
{
    public partial class StatisticsForm : Form
    {
        const byte k_MaxMark = 100;
        private static StatisticsForm s_Instance = null;

        private StatisticsForm()
        {
            InitializeComponent();
        }

        public static StatisticsForm GetInstanceOfStaticsForm()
        {

            if (s_Instance == null)
            {
                s_Instance = new StatisticsForm();
            }

            return s_Instance;
        }

        public CalculateAvg CalAverageStats { get; internal set; }

        public void LoadData(Dictionary<string, CalculateAvg> yearsAvg)
        {
            avgsListView.Items.Clear();               

           

            foreach (KeyValuePair<string, CalculateAvg> yearAvg in yearsAvg)
            {
                ListViewItem lvi = new ListViewItem(yearAvg.Key);
                lvi.SubItems.Add(yearAvg.Value.ToString());

                UtillsColors.RowColor(lvi, avgsListView.Items.Count);

                avgsListView.Items.Add(lvi);

            }

            float AvrgTotal = CalAverageStats.AverageTotal;
            updateAllMarkPointsData(AvrgTotal);
                        
            numericUpDown1.Minimum = Convert.ToDecimal(AvrgTotal);
            numericUpDown2.Value = 2.0m;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            float mark = Convert.ToSingle(numericUpDown1.Value);
            updateAllMarkPointsData(mark);

            if (checkBox1.CheckState == CheckState.Checked)
            {
                numericUpDown2_ValueChanged(sender, e);
            }
        }

        private void markColorsIfPassMaxMark(Label i_LabelMark, float i_Mark, Color i_DefualtColor, Color i_OutOfLimit)
        {
            Color currectColor = i_DefualtColor;

            if (i_Mark > k_MaxMark)
            {
                currectColor = i_OutOfLimit;
            }

            i_LabelMark.ForeColor = currectColor;
        }

        private void updateAllMarkPointsData(float i_Mark)
        {
            // k_MaxMark = 100

            float points3 = CalAverageStats.ReachAvrg(i_Mark, 3);
            float points4 = CalAverageStats.ReachAvrg(i_Mark, 4);
            float points5 = CalAverageStats.ReachAvrg(i_Mark, 5);

            string myFormatBase = "{0:0}";

            markColorsIfPassMaxMark(points5Label, points5, Color.Black, Color.Red);
            markColorsIfPassMaxMark(points4Label, points4, SystemColors.Highlight, Color.Red);
            markColorsIfPassMaxMark(points3Label, points3, Color.Black, Color.Red);

            points3Label.Text = string.Format(myFormatBase, points3);
            points4Label.Text = string.Format(myFormatBase, points4);
            points5Label.Text = string.Format(myFormatBase, points5);

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = SystemColors.Highlight;
            button1.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
            button1.ForeColor = SystemColors.Highlight;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            // k_MaxMark = 100
            float mark = Convert.ToSingle(numericUpDown1.Value);
            float points = Convert.ToSingle(numericUpDown2.Value);
            float markNeeded = CalAverageStats.ReachAvrg(mark, points);

            if (markNeeded > k_MaxMark)
            {
                labelFreePointsChoose.ForeColor = Color.Red;
            }
            else
            {
                labelFreePointsChoose.ForeColor = Color.White;
            }

            labelFreePointsChoose.Text = string.Format("{0:0}", markNeeded);
        }

        // labelFreePointsChoose

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                numericUpDown2.Visible = labelFreePointsChoose.Visible = true;
            }
            else
            {
                numericUpDown2.Visible = labelFreePointsChoose.Visible = false;
            }
        }

        public void ShowDialog(Dictionary<string, CalculateAvg> yearAvg, CalculateAvg m_CalAvg)
        {
            CalAverageStats = m_CalAvg;
            LoadData(yearAvg);
            ShowDialog();
        }
              

        public void BestCourseValueToImprove(List<CourseDiffrence> allCourseDiffrences)
        {
            HelpShimonAlgorit(allCourseDiffrences);
        }

        private void HelpShimonAlgorit(List<CourseDiffrence> allCourseDiffrences)
        {
            const string notAvilable = "Not avilable";
            string toLabelBest1 = notAvilable, toLabelBest2 = notAvilable;

            if (allCourseDiffrences.Count > 1)
            {
                /////////////////////////////////////// start was here

                //CourseDiffrence max1, max2;

                //max1 = allCourseDiffrences[0];
                //max2 = allCourseDiffrences[1];

                //foreach (CourseDiffrence item in allCourseDiffrences.Skip(1))
                //{
                //    if (max1 < item)
                //    {
                //        max2 = max1;
                //        max1 = item;
                //    }
                //}

                //toLabelBest1 = max1.CourseName;
                //toLabelBest2 = max2.CourseName;

                //////////////////////////////////////////// end here was
                // Try The 2 Bests Algorit Tomorrow. conver to c# and do it good for my prog.
                // maybe to open a class for this algorit and beaiver.

                allCourseDiffrences.Sort();

                toLabelBest1 = allCourseDiffrences[0].CourseName;
                toLabelBest2 = allCourseDiffrences[1].CourseName;

            }
            else if (allCourseDiffrences.Count == 1)
            {
                toLabelBest1 = allCourseDiffrences[0].CourseName;
            }

            labelBest.Text = toLabelBest1;
            labelSecoundBest.Text = toLabelBest2;
        }
    }
}