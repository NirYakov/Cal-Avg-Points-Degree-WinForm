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
                dataListView.Items[listViewCount - 1].BackColor =  Color.LightGray; // Color.Gray ;
                // dataListView.Items[listViewCount - 1].ForeColor = Color.White;
            }

            m_CalAvg.AddMarkAndPoints(i_DataToList[(int)eSubItem.Mark], i_DataToList[(int)eSubItem.Points]);
            markLabel.Text = m_CalAvg.ToString() ;
        }        

        private void button1_Click(object sender, EventArgs e)
        {           
            r_Form3.ShowDialog();

            // markLabel.Text = "21";
           
            r_Form3.Hide();
        }        

        public void SaveNewData()
        {

            if (saveChangesCheckBox.CheckState == CheckState.Checked)
            {                
                const string endFile = ".txt";

                string[] allDataLines = new string[dataListView.Items.Count];
                int i = 0;
                foreach (ListViewItem item in dataListView.Items)
                {
                    //
                    string toChange;
                    if (item.SubItems[(int)eSubItem.Semseter].Text == "1")
                    {
                        toChange = "A";
                    } else if (item.SubItems[(int)eSubItem.Semseter].Text == "2")
                    {
                        toChange = "B";
                    }
                    else
                    {
                        toChange = "C";
                    }
                    //
                    allDataLines[i++] = string.Format("{0},{1},{2},{3},{4}"
                   , item.SubItems[(int)eSubItem.CourseName].Text, item.SubItems[(int)eSubItem.Mark].Text
                   , item.SubItems[(int)eSubItem.Points].Text, item.SubItems[(int)eSubItem.Year].Text
                   , toChange/*item.SubItems[(int)eSubItem.Semseter].Text*/);

                }

                File.WriteAllLines(string.Format(@"UsersData\{0}{1}", r_UserFileName, endFile) , allDataLines);                
                
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Bye im Closed (MainForm)");
        }
    }    
}

public enum eSmester
{
    A = 'A' ,
    B = 'B' ,
    C = 'C'
}

public enum eSubItem
{
    CourseName,
    Mark,
    Points,
    Year,
    Semseter

}
