﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Logic_And_Settings;

namespace FormsActive
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

            loadDataToListViewFromFile();
        }

        public void AddWithEvent(string[] i_ToAdd)
        {
            m_ChangedListView = true;
            addItemToListView(i_ToAdd);
        }

        private void loadDataToListViewFromFile()
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
            try
            {
                ListViewItem lvi = new ListViewItem(i_DataToList[(int)eSubItem.CourseName]);
                lvi.SubItems.Add(i_DataToList[(int)eSubItem.Mark]);
                lvi.SubItems.Add(i_DataToList[(int)eSubItem.Points]);
                lvi.SubItems.Add(i_DataToList[(int)eSubItem.Year]);
                lvi.SubItems.Add(i_DataToList[(int)eSubItem.Semseter]);

                UtillsColors.RowColor(lvi, dataListView.Items.Count);

                m_CalAvg.AddMarkAndPoints(i_DataToList[(int)eSubItem.Mark], i_DataToList[(int)eSubItem.Points]);
                updateMarkAverageLabel();
                updateTotalPoints();

                dataListView.Items.Add(lvi);
            }
            catch (Exception)
            {
                MessageBox.Show(string.Format("Error in type please try{0}again after check the '?'", Environment.NewLine));
            }
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

        private List<CourseDiffrence> CourseDiffrencesInData()
        {
            List<CourseDiffrence> allCourseDiffrences = new List<CourseDiffrence>(dataListView.Items.Count);
            foreach (ListViewItem item in dataListView.Items)
            {
                float diffrenceValue = CalculateAvg.DifferenceValueTo100(
                    item.SubItems[(int)eSubItem.Mark].Text, item.SubItems[(int)eSubItem.Points].Text);

                allCourseDiffrences.Add(new CourseDiffrence(
                        item.SubItems[(int)eSubItem.CourseName].Text, diffrenceValue));
            }

            return allCourseDiffrences;
        }

        private void statisticsButton_Click(object sender, EventArgs e)
        {
            if (m_StatisticsForm == null)
            {
                m_StatisticsForm = StatisticsForm.GetInstanceOfStaticsForm();
            }

            m_StatisticsForm.BestCourseValueToImprove(CourseDiffrencesInData());
            m_StatisticsForm.ShowDialog(GetDictionaryMarkByYears(), m_CalAvg);
        }

        private void removeCourseToolStripMenuItem_Click(object sender, EventArgs e) // ask guy ronen maybe . !!
        {
            try
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
                    updateMarkAverageLabel();
                    updateTotalPoints();
                    m_ChangedListView = true;
                    MessageBox.Show("Remove " + removedItemName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error , try to pick a row .(Row will be in blue.)");
            }
        }

        private void changeMarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataListView.Items.Count > 0)
                {
                    if (m_FormToChangeTheMark == null)
                    {
                        m_FormToChangeTheMark = FormChangeMark.GetInstanceOfFormChangeMark();
                    }

                    ListViewItem itemToChange = dataListView.SelectedItems[0];
                    string chosenCourseName = itemToChange.SubItems[(int)eSubItem.CourseName].Text;
                    string chosenCourePoints = itemToChange.SubItems[(int)eSubItem.Points].Text;
                    byte markToChange = byte.Parse(itemToChange.SubItems[(int)eSubItem.Mark].Text);

                    if (m_FormToChangeTheMark.ShowDialog(chosenCourseName, markToChange, m_CalAvg, chosenCourePoints) == DialogResult.OK)
                    {
                        short totalOffset = (short)(m_FormToChangeTheMark.LastValue - markToChange);
                        itemToChange.SubItems[(int)eSubItem.Mark].Text = m_FormToChangeTheMark.LastValue.ToString();
                        m_CalAvg.ChangeMarkAndTotal(totalOffset.ToString(), itemToChange.SubItems[(int)eSubItem.Points].Text);
                        updateMarkAverageLabel();
                        updateTotalPoints();
                        m_ChangedListView = true;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error , try to pick a row .(Row will be in blue.)");
            }
        }

        private void updateMarkAverageLabel()
        {
            markLabel.Text = m_CalAvg.ToString();
        }

        private void updateTotalPoints()
        {
            labelTotalPoints.Text = string.Format("{0:00.00}", m_CalAvg.PointsTotal);
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

        private void showPotensialValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception)
            {
                MessageBox.Show("Error , try to pick a row .(Row will be in blue.)");
            }
        }



        #region Add that to progress bar ro something that all , when i can add the Goal .! serlasetion.!
        // private float m_PointsGoal = 120;
        //        private void InfoPointsProgress()
        //        {
        //            float pointsTotal = m_CalAvg.PointsTotal, percentPoints = pointsTotal / m_PointsGoal;
        //            string bodyMessage = string.Format(
        //@"Points collected : {0}
        //Points Percent from gaol {1}", pointsTotal, percentPoints);
        //            MessageBox.Show(bodyMessage, "Info progress");
        //        }
        #endregion

        int m_SortCol = 0;

        private void dataListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (checkBoxSortCol.Checked)
            {

                if (e.Column != m_SortCol)
                {
                    m_SortCol = e.Column;
                    dataListView.Sorting = SortOrder.Ascending;
                }
                else
                {
                    if (dataListView.Sorting == SortOrder.Ascending)
                    {
                        dataListView.Sorting = SortOrder.Descending;
                    }
                    else
                    {
                        dataListView.Sorting = SortOrder.Ascending;
                    }

                    ListViewItemComparer lvic = ListViewItemComparer.GetInstance();

                    dataListView.ListViewItemSorter = lvic.SortingClass(e.Column, dataListView.Sorting);

                    m_ChangedListView = true;

                    int indexToColor = 0;
                    foreach (ListViewItem item in dataListView.Items)
                    {
                        UtillsColors.RowColor(item,indexToColor);
                        indexToColor++;
                    }
                }
            }

        }
    }

    public class ListViewItemComparer : IComparer
    {
        private static ListViewItemComparer m_Instance = null;
        private int m_ColNumber = 0;
        private SortOrder m_SortOrder = SortOrder.Ascending;


        private ListViewItemComparer()
        {

        }

        public static ListViewItemComparer GetInstance()
        {
            if (m_Instance == null)
            {
                m_Instance = new ListViewItemComparer();
            }

            return m_Instance;
        }

        public ListViewItemComparer SortingClass(int i_Col, SortOrder i_SortOrder)
        {
            m_ColNumber = i_Col;
            m_SortOrder = i_SortOrder;

            return this;
        }

        public int Compare(object x, object y)
        {
            int returnVal = 0;

            ListViewItem lviLeft = x as ListViewItem, lviRight = y as ListViewItem;

            if (m_ColNumber == (int)eSubItem.CourseName || m_ColNumber == (int)eSubItem.Semseter)
            {
                returnVal = string.Compare(lviLeft.SubItems[m_ColNumber].Text, lviRight.SubItems[m_ColNumber].Text);
                
            }
            else
            {
                float numberLeft = float.Parse(lviLeft.SubItems[m_ColNumber].Text);
                float numberRight = float.Parse(lviRight.SubItems[m_ColNumber].Text);

                returnVal = (int)(numberLeft - numberRight);                
            }

            if (m_SortOrder == SortOrder.Descending)
            {
                returnVal *= -1;
            }

            return returnVal;
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