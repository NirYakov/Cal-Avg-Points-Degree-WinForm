using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            loadDataToListView();
        }


        private void loadDataToListView()
        {
            string[] testData = { "Prog C" , "79" , "5" , "1" ,"1" };
            addItemToListView(testData);

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

    }
}
