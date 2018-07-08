using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Data_Interface
{
    public partial class OpenningForm : Form
    {
        public OpenningForm()
        {
            InitializeComponent();
            addToUserCombolist();
        }

        private void radioButtons()
        {
            bool savedUser = newUserRadioButton.Checked == true;

            usersComboBox.Enabled = !savedUser;
            newUserTextBox.Enabled = savedUser;
        }

        private void newUserRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            radioButtons();
        }

        public bool IsHaveNewUser() => newUserRadioButton.Checked == true;

        public string NewUser
        {
            get { return newUserTextBox.Text; }
        }

        public string ComboChosen
        {
            get
            {
                return usersComboBox.SelectedItem.ToString();
            }
        }        

        private void addToUserCombolist()
        {
            string dataUserPath = "UsersData";
            string currectDataPath = string.Format(@"{0}\{1}", Path.GetFullPath("."), dataUserPath);
            int startPathLen = currectDataPath.Length + 1;
            foreach (string item in Directory.GetFiles(currectDataPath))
            {
                if (item.EndsWith(".txt"))
                {
                    int startAndEnd = (item.Length - startPathLen - 4);
                    string fileName = item.Substring(startPathLen, startAndEnd);
                    usersComboBox.Items.Add(fileName);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
