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
using Cal_Avrg_To_Degree_Points;

namespace Data_Interface
{
    public partial class MainForm : Form
    {
        private readonly string r_UserFileName;
        private AddItemsForm m_AddItemsForm = null;
        private CalculateAvg m_CalAvg;
        private bool m_ChangedListView = false;
        private StatisticsForm m_StatisticsForm = null;
        private FormChangeMark m_FormToChangeTheMark = null;

        public MainForm(string i_UserFileName)
        {
            InitializeComponent();

            r_UserFileName = i_UserFileName;

            loadDataToListView();
        }

        public void AddWithEvent(string[] i_ToAdd)
        {
            m_ChangedListView = true;
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

            UtillsColors.RowColor(lvi, dataListView.Items.Count);

            dataListView.Items.Add(lvi);

            m_CalAvg.AddMarkAndPoints(i_DataToList[(int)eSubItem.Mark], i_DataToList[(int)eSubItem.Points]);
            updateMarkAverageLabel();
        }

        private void addNewButton_Click(object sender, EventArgs e)
        {
            if (m_AddItemsForm == null)
            {
                m_AddItemsForm = AddItemsForm.GetInstanceOfAddItemsForm();
                m_AddItemsForm.AddCurse += AddWithEvent;
            }

            m_AddItemsForm.ShowDialog();
            m_AddItemsForm.Hide();
        }

        private void saveNewData()
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

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (m_ChangedListView == true)
            {
                if (MessageBox.Show(
@"Hi, if you want to save
all the changes then click 'Yes'", "Save Data", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    saveNewData();
                }
            }
        }

        private Dictionary<string, CalculateAvg> GetDictionaryMarkByYears()
        {
            Dictionary<string, CalculateAvg> yearAvg = new Dictionary<string, CalculateAvg>();
            foreach (ListViewItem item in dataListView.Items)
            {
                string yearOfCurrentItem = item.SubItems[(int)eSubItem.Year].Text;
                if (yearAvg.ContainsKey(yearOfCurrentItem))
                {
                    yearAvg[yearOfCurrentItem] = yearAvg[yearOfCurrentItem].AddMarkAndPoints(item.SubItems[(int)eSubItem.Mark].Text, item.SubItems[(int)eSubItem.Points].Text);
                }
                else
                {
                    CalculateAvg newCalAvg = new CalculateAvg();
                    newCalAvg.AddMarkAndPoints(item.SubItems[(int)eSubItem.Mark].Text, item.SubItems[(int)eSubItem.Points].Text);
                    yearAvg.Add(yearOfCurrentItem, newCalAvg);
                }
            }

            return yearAvg;
        }

        private void statisticsButton_Click(object sender, EventArgs e)
        {
            if (m_StatisticsForm == null)
            {
                m_StatisticsForm = StatisticsForm.GetInstanceOfStaticsForm();
            }

            m_StatisticsForm.ShowDialog(GetDictionaryMarkByYears(), m_CalAvg);
        }

        private void removeCourseToolStripMenuItem_Click(object sender, EventArgs e) // ask guy ronen maybe . !!
        {
            if (dataListView.Items.Count > 0)
            {
                string removedItemName = dataListView.SelectedItems[0].SubItems[(int)eSubItem.CourseName].Text;
                string removeItemMark = dataListView.SelectedItems[0].SubItems[(int)eSubItem.Mark].Text;
                string removeItemPoints = dataListView.SelectedItems[0].SubItems[(int)eSubItem.Points].Text;

                int currentRowThatRemove = dataListView.SelectedItems.IndexOf(dataListView.SelectedItems[0]);

                m_CalAvg.SubstractMarkAndPoints(removeItemMark, removeItemPoints);

                dataListView.Items.Remove(dataListView.SelectedItems[0]);

                int indexRowToColor = 0;
                foreach (ListViewItem item in dataListView.Items)
                {
                    UtillsColors.RowColor(item, indexRowToColor);
                    indexRowToColor++;
                }

                int dataListViewLength = dataListView.Items.Count;

                //for (int i = currentRowThatRemove; i < dataListViewLength; i++)
                //{
                //    rowColor(dataListView.Items[i], i);
                //}                

                updateMarkAverageLabel();

                m_ChangedListView = true;

                MessageBox.Show("Remove " + removedItemName);
            }
        }

        private void changeMarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataListView.Items.Count > 0)
            {
                if (m_FormToChangeTheMark == null)
                {
                    m_FormToChangeTheMark = FormChangeMark.GetInstanceOfFormChangeMark();
                }

                ListViewItem itemToChange = dataListView.SelectedItems[0];
                string chosenCourseName = itemToChange.SubItems[(int)eSubItem.CourseName].Text;
                byte markToChange = byte.Parse(itemToChange.SubItems[(int)eSubItem.Mark].Text);

                if (m_FormToChangeTheMark.ShowDialog(chosenCourseName, markToChange) == DialogResult.OK)
                {
                    short totalOffset = (short)(m_FormToChangeTheMark.LastValue - markToChange);
                    itemToChange.SubItems[(int)eSubItem.Mark].Text = m_FormToChangeTheMark.LastValue.ToString();
                    m_CalAvg.ChangeMarkAndTotal(totalOffset.ToString(), itemToChange.SubItems[(int)eSubItem.Points].Text);
                    updateMarkAverageLabel();
                    m_ChangedListView = true;
                }
            }
        }

        private void updateMarkAverageLabel()
        {
            markLabel.Text = m_CalAvg.ToString();
        }

        #region this is something that i cant know or explaine how to use and how to modifi to my personal use.

        //private void changeMarkToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //    if (dataListView.Items.Count > 0)
        //    {
        //        // dataListView.Items.Remove(dataListView.SelectedItems[0]);
        //        dataListView.LabelEdit = true;
        //        ListViewItem lvi = dataListView.SelectedItems[0];
        //        lvi.BeginEdit();

        //        dataListView.SelectedItems[0].BeginEdit();
        //        // dataListView.LabelEdit = false;
        //    }
        //}

        #endregion

        private void infoButton_Click(object sender, EventArgs e)
        {
            float currentAvg = m_CalAvg.AverageTotal;
            MessageBox.Show(string.Format("Marks total ->> {0}{2}Points total ->>{1}{2}"
                , m_CalAvg.MarkTotal, m_CalAvg.PointsTotal, Environment.NewLine));
        }

        private void showPotensialValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataListView.Items.Count > 0)
            {
                string markString = dataListView.SelectedItems[0].SubItems[(int)eSubItem.Mark].Text;
                string pointsString = dataListView.SelectedItems[0].SubItems[(int)eSubItem.Points].Text;

                float differenceValue = CalculateAvg.DifferenceValueTo100(markString, pointsString);

                MessageBox.Show(string.Format(
                        "Potensian more mark (untill up to 100) {0} the potensian is {1}", Environment.NewLine, differenceValue)
                        , "Mark Potenseal");
            }
        }
    }
}

    public enum eSubItem : byte
    {
        CourseName,
        Mark,
        Points,
        Year,
        Semseter
    }