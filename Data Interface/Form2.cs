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

namespace Data_Interface
{
    public partial class Form2 : Form
    {
        public Form2(string i_UserFileName)
        {
            InitializeComponent();

            r_UserFileName = i_UserFileName;

            loadDataToListView();

            

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
            ListViewItem lvi = new ListViewItem(i_DataToList[0]);
            lvi.SubItems.Add(i_DataToList[1]);
            lvi.SubItems.Add(i_DataToList[2]);
            lvi.SubItems.Add(i_DataToList[3]);
            lvi.SubItems.Add(i_DataToList[4]);

            dataListView.Items.Add(lvi);
        }

        private readonly Form3 r_Form3 = new Form3();

        private void button1_Click(object sender, EventArgs e)
        {
            r_Form3.ClearNewData();
            r_Form3.ShowDialog();

            LinkedList<string[]> dataList = r_Form3.NewDataArray;
            if (dataList.Count > 0)
            {
                foreach (string[] item in dataList)
                {
                    addItemToListView(item);
                }


            }

            r_Form3.Hide();
        }

        private readonly string r_UserFileName;

        public void SaveNewData()
        {

            if (saveChangesCheckBox.CheckState == CheckState.Checked)
            {                
                const string endFile = ".txt";

                string[] allDataLines = new string[dataListView.Items.Count];
                int i = 0;
                foreach (ListViewItem item in dataListView.Items)
                {
                    allDataLines[i++] = string.Format("{0},{1},{2},{3},{4}"
                   , item.SubItems[0].Text, item.SubItems[1].Text, item.SubItems[2].Text
                   , item.SubItems[3].Text, item.SubItems[4].Text);

                }

                File.WriteAllLines(string.Format(@"UsersData\{0}{1}", r_UserFileName, endFile) , allDataLines);
                
            }
        }
    }
}
