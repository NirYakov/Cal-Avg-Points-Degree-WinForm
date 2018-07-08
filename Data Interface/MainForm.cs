using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cal_And_Utills_To_Degree_Points;

namespace Data_Interface
{
    public partial class MainForm : Form
    {
        private readonly string r_UserFileName;
        private readonly AddItemsForm r_Form3 = new AddItemsForm();
        private CalculateAvg m_CalAvg;


        public MainForm(string i_UserFileName)
        {
            InitializeComponent();

            r_UserFileName = i_UserFileName;

            loadDataToListView();

            r_Form3.AddCurse += AddWithEvent;
        }

        public void AddWithEvent(string[] i_ToAdd)
        {
            addItemToListView(i_ToAdd);
        }


        private void loadDataToListView()
        {
            const string endFile = ".txt";
            string[] testData = File.ReadAllLines(string.Format(@"UsersData\{0}{1}", r_UserFileName, endFile));
            foreach (string item in testData)
            {
                string[] splitToColsString = item.Split(',');
                addItemToListView(splitToColsString);
            }
        }

        private void addItemToListView(string[] i_DataToList)
        {
            ListViewItem lvi = new ListViewItem(i_DataToList[(int)eSubItem.CourseName]);
            lvi.SubItems.Add(i_DataToList[(int)eSubItem.Mark]);
            lvi.SubItems.Add(i_DataToList[(int)eSubItem.Points]);
            lvi.SubItems.Add(i_DataToList[(int)eSubItem.Year]);
            lvi.SubItems.Add(i_DataToList[(int)eSubItem.Semseter]);

            dataListView.Items.Add(lvi);

            int listViewCount = dataListView.Items.Count;

            if (listViewCount % 2 == 0)
            {
                dataListView.Items[listViewCount - 1].BackColor = Color.LightGray; // Color.Gray ;
                // dataListView.Items[listViewCount - 1].ForeColor = Color.White;
            }

            m_CalAvg.AddMarkAndPoints(i_DataToList[(int)eSubItem.Mark], i_DataToList[(int)eSubItem.Points]);
            markLabel.Text = m_CalAvg.ToString();
        }

        private void addNewButton_Click(object sender, EventArgs e)
        {
            r_Form3.ShowDialog();
            r_Form3.Hide();
        }

        private void saveNewData()
        {

            if (saveChangesCheckBox.CheckState == CheckState.Checked)
            {
                const string endFile = ".txt";

                string[] allDataLines = new string[dataListView.Items.Count];
                int i = 0;
                foreach (ListViewItem item in dataListView.Items)
                {
                    allDataLines[i++] = string.Format("{0},{1},{2},{3},{4}"
                   , item.SubItems[(int)eSubItem.CourseName].Text, item.SubItems[(int)eSubItem.Mark].Text
                   , item.SubItems[(int)eSubItem.Points].Text, item.SubItems[(int)eSubItem.Year].Text
                   , item.SubItems[(int)eSubItem.Semseter].Text);

                }

                File.WriteAllLines(string.Format(@"UsersData\{0}{1}", r_UserFileName, endFile), allDataLines);

            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            saveNewData();
            MessageBox.Show("Bye im Closed (MainForm)");
        }

        private StatisticsForm m_StatisticsForm = null;

        private void statisticsButton_Click(object sender, EventArgs e)
        {
            if (m_StatisticsForm == null)
            {
                m_StatisticsForm = new StatisticsForm();
            }

            Dictionary<string, CalculateAvg> yearAvg = new Dictionary<string, CalculateAvg>();
            foreach (ListViewItem item in dataListView.Items)
            {
                string yearOfCurrentItem = item.SubItems[(int)eSubItem.Year].Text;
                if (yearAvg.ContainsKey(yearOfCurrentItem))
                {
                    //MessageBox.Show( yearAvg[yearOfCurrentItem].AddMarkAndPoints(item.SubItems[(int)eSubItem.Mark].Text, item.SubItems[(int)eSubItem.Points].Text));
                    /* yearAvg[yearOfCurrentItem] = */  yearAvg[yearOfCurrentItem].AddMarkAndPoints(item.SubItems[(int)eSubItem.Mark].Text, item.SubItems[(int)eSubItem.Points].Text);
                    
                    UpdateCalAvg(ref yearAvg[yearOfCurrentItem], item.SubItems[(int)eSubItem.Mark].Text, item.SubItems[(int)eSubItem.Points].Text);
                    
                    //MessageBox.Show(string.Format("{0} ,,, {1}",yearAvg[yearOfCurrentItem].AverageTotal , item.SubItems[(int)eSubItem.Mark].Text));
                }
                else
                {
                    CalculateAvg newCalAvg = new CalculateAvg();
                    newCalAvg.AddMarkAndPoints(item.SubItems[(int)eSubItem.Mark].Text, item.SubItems[(int)eSubItem.Points].Text);
                    yearAvg.Add(yearOfCurrentItem, newCalAvg);
                }
            }

            m_StatisticsForm.LoadData(yearAvg);

            m_StatisticsForm.ShowDialog();
        }

        private void UpdateCalAvg(ref CalculateAvg i_CurrentCalAvg, string i_Mark, string i_Points)
        {
            i_CurrentCalAvg.AddMarkAndPoints(i_Mark, i_Points);
        }
    }
}

public enum eSubItem
{
    CourseName,
    Mark,
    Points,
    Year,
    Semseter

}
