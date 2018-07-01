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
        public Form2()
        {
            InitializeComponent();

            r_UserFileName = "Nir y";

            loadDataToListView();
            
        }


        private void loadDataToListView()
        {
            string[] testData = File.ReadAllLines(@"UsersData\Nir y.txt");
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

        ~Form2()
        {
            if (saveChangesCheckBox.Checked == true)
            {
                const string endFile = ".txt";
                FileStream fs = File.OpenWrite(string.Format( @".\UserData\{0}{1}",r_UserFileName, endFile));

                string[] allDataLines = new string[dataListView.Items.Count];
                int i = 0;
                foreach (ListViewItem item in dataListView.Items)
                {
                    /*string dataLine*/ allDataLines[i++] = string.Format("{0},{1},{2,{3},{4}"
                        ,item.SubItems[0], item.SubItems[1], item.SubItems[2], item.SubItems[3], item.SubItems[4]);

                    MessageBox.Show("Here");

                }

                File.WriteAllLines(string.Format(@"UserData\{0}{1}", r_UserFileName, endFile) , allDataLines);

                

                fs.Close();
            }
        }
    }
}
