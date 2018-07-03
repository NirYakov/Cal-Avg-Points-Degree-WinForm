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
    public partial class AddItemsForm : Form
    {       
        public event Action<string[]> AddCurse;

        public AddItemsForm()
        {
            InitializeComponent();
        }

        protected void OnAddCurse(string[] i_NewAddCurse)
        {
            if (AddCurse != null)
            {
                AddCurse.Invoke(i_NewAddCurse);
            }
        }        

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || 
                textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                string[] newData = new string[5];
                newData[(int)eSubItem.CourseName] = textBox1.Text;
                newData[(int)eSubItem.Mark] = textBox2.Text;
                newData[(int)eSubItem.Points] = textBox3.Text;
                newData[(int)eSubItem.Year] = textBox4.Text;
                newData[(int)eSubItem.Semseter] = textBox5.Text;

                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = string.Empty;

                OnAddCurse(newData);
            }
        }
    }
}
