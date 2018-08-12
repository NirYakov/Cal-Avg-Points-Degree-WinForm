﻿using System;
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
        private AddItemsForm m_AddItemsForm = null;
        private CalculateAvg m_CalAvg;
        private bool m_ChangedListView = false;

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

        private void rowsColorZebra()
        {
            short colorChanger = 0;
            foreach (ListViewItem item in dataListView.Items)
            {
                if (colorChanger % 2 != 0)
                {
                    item.BackColor = Color.LightBlue;
                }

                colorChanger++;
            }
        }

        private void rowColor(ListViewItem i_ListViewRowItem, int i_RowNumber)
        {
            if (i_RowNumber % 2 != 0)
            {
                i_ListViewRowItem.BackColor = Color.LightGray; // Color.LightBlue ;                
            }
            else
            {
                i_ListViewRowItem.BackColor = Color.White;
            }
        }

        private void addItemToListView(string[] i_DataToList)
        {
            ListViewItem lvi = new ListViewItem(i_DataToList[(int)eSubItem.CourseName]);
            lvi.SubItems.Add(i_DataToList[(int)eSubItem.Mark]);
            lvi.SubItems.Add(i_DataToList[(int)eSubItem.Points]);
            lvi.SubItems.Add(i_DataToList[(int)eSubItem.Year]);
            lvi.SubItems.Add(i_DataToList[(int)eSubItem.Semseter]);

            rowColor(lvi, dataListView.Items.Count);

            dataListView.Items.Add(lvi);

            m_CalAvg.AddMarkAndPoints(i_DataToList[(int)eSubItem.Mark], i_DataToList[(int)eSubItem.Points]);
            markLabel.Text = m_CalAvg.ToString();
        }

        private void addNewButton_Click(object sender, EventArgs e)
        {
            if (m_AddItemsForm == null)
            {
                m_AddItemsForm = new AddItemsForm();
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
                    yearAvg[yearOfCurrentItem] = yearAvg[yearOfCurrentItem].AddMarkAndPoints(item.SubItems[(int)eSubItem.Mark].Text, item.SubItems[(int)eSubItem.Points].Text);
                }
                else
                {
                    CalculateAvg newCalAvg = new CalculateAvg();
                    newCalAvg.AddMarkAndPoints(item.SubItems[(int)eSubItem.Mark].Text, item.SubItems[(int)eSubItem.Points].Text);
                    yearAvg.Add(yearOfCurrentItem, newCalAvg);
                }
            }

            m_StatisticsForm.CalAverageStats = m_CalAvg;
            m_StatisticsForm.LoadData(yearAvg);
            m_StatisticsForm.ShowDialog();
        }

        private void removeCurseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bye Course");
        }

        private void removeCourseToolStripMenuItem_Click(object sender, EventArgs e) // ask guy ronen maybe . !!
        {
            if (dataListView.Items.Count > 0)
            {
                string removedItemName = dataListView.SelectedItems[0].SubItems[(int)eSubItem.CourseName].Text;
                string removeItemMark = dataListView.SelectedItems[0].SubItems[(int)eSubItem.Mark].Text;
                string removeItemPoints = dataListView.SelectedItems[0].SubItems[(int)eSubItem.Points].Text;

                markLabel.Text = m_CalAvg.ToString();

                int currentRowThatRemove = dataListView.SelectedItems.IndexOf(dataListView.SelectedItems[0]);

                m_CalAvg.SubstractMarkAndPoints(removeItemMark, removeItemPoints);

                dataListView.Items.Remove(dataListView.SelectedItems[0]);

                int indexRowToColor = 0;
                foreach (ListViewItem item in dataListView.Items)
                {
                    rowColor(item, indexRowToColor);
                    indexRowToColor++;
                }

                int dataListViewLength = dataListView.Items.Count;

                //for (int i = currentRowThatRemove; i < dataListViewLength; i++)
                //{
                //    rowColor(dataListView.Items[i], i);
                //}

                MessageBox.Show("Remove " + removedItemName);
            }
        }

      //  private FormChangeMark() { }

        private void changeMarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataListView.Items.Count > 0)
            {
                string chosenCourseName = dataListView.SelectedItems[0].SubItems[(int)eSubItem.CourseName].Text;
                


            }
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
