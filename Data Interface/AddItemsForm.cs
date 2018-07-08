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
            if (textBox1.Text != "" || textBox2.Text != "" ||
                textBox3.Text != "" || textBox4.Text != "")
            {
                string[] newData = new string[5];
                newData[(int)eSubItem.CourseName] = textBox1.Text;
                newData[(int)eSubItem.Mark] = textBox2.Text;
                newData[(int)eSubItem.Points] = textBox3.Text;
                newData[(int)eSubItem.Year] = textBox4.Text;
                string semesterStr;
                if (radioButton1.Checked == true)
                {
                    semesterStr = radioButton1.Text;
                }
                else if (radioButton2.Checked == true)
                {
                    semesterStr = radioButton2.Text;
                }
                else
                {
                    semesterStr = radioButton3.Text;
                }

                newData[(int)eSubItem.Semseter] = semesterStr;

                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = string.Empty;

                OnAddCurse(newData);
            }
            else
            {
                MessageBox.Show(
@"You can't leave empty
text in the text boxes");
            }
        }

    }
}
