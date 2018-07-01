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
    public partial class Form3 : Form
    {

        private readonly LinkedList<string[]> r_NewDataList = new LinkedList<string[]>();
            
        public Form3()
        {
            InitializeComponent();
        }

        public LinkedList<string[]> NewDataArray
        {
            get
            {                
                return r_NewDataList;
            }
        }

        internal void ClearNewData()
        {
            r_NewDataList.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            string[] newData = new string[5];
            newData[0] = textBox1.Text;
            newData[1] = textBox2.Text;
            newData[2] = textBox3.Text;
            newData[3] = textBox4.Text;
            newData[4] = textBox5.Text;

            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = string.Empty;

            

            r_NewDataList.AddLast(newData);

        }


    }
}
