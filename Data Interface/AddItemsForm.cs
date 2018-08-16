using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic_And_Settings;

namespace Data_Interface
{
    public partial class AddItemsForm : Form
    {
        public event Action<string[]> AddCurse;
        private static AddItemsForm s_Instance = null;
        private static readonly RightInputStrings sr_CheckInput = null;

        private AddItemsForm()
        {
            InitializeComponent();           
        }

        static AddItemsForm()
        {
            sr_CheckInput = new RightInputStrings();
        }

        public static AddItemsForm GetInstanceOfAddItemsForm()
        {
            if (s_Instance == null)
            {
                s_Instance = new AddItemsForm();
            }

            return s_Instance;
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
            if (textBoxCourseName.Text != "" || textBoxMark.Text != "" ||
                textBoxPoints.Text != "" || textBoxYear.Text != "")
            {
                string[] newData = new string[5];
                newData[(int)eSubItem.CourseName] = textBoxCourseName.Text;
                newData[(int)eSubItem.Mark] = textBoxMark.Text;
                newData[(int)eSubItem.Points] = textBoxPoints.Text;
                newData[(int)eSubItem.Year] = textBoxYear.Text;
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

                textBoxCourseName.Text = textBoxMark.Text = textBoxPoints.Text = textBoxYear.Text = string.Empty;

                OnAddCurse(newData);
            }
            else
            {
                MessageBox.Show(
@"You can't leave empty
text in the text boxes");
            }
        }

        private void textBoxCourseName_Leave(object sender, EventArgs e)
        {

        }

        private void textBoxMark_Leave(object sender, EventArgs e)
        {

        }

        private void textBoxPoints_Leave(object sender, EventArgs e)
        {

        }

        private void textBoxYear_Leave(object sender, EventArgs e)
        {

        }
    }
}
