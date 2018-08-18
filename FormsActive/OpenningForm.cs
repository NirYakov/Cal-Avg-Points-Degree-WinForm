using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace FormsActive
{
    public partial class OpenningForm : Form
    {
        string m_UserName;

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

        public void UserEnternce()
        {
            string nameOfUser;

            if (radioButtonSavedUser.Checked)
            {
                nameOfUser = usersComboBox.SelectedItem.ToString();
            }
            else
            {
                nameOfUser = newUserTextBox.Text;
                FileStream fs = File.OpenWrite(string.Format(@"UsersData\{0}.txt", newUserTextBox.Text));
                fs.Close();
            }

            m_UserName = nameOfUser;
        }

        public string UserName { get => m_UserName;  }

        private void addToUserCombolist()
        {
            string dataUserPath = "UsersData";
            string currectDataPath = string.Format(@"{0}\{1}", Path.GetFullPath("."), dataUserPath);
            int startPathLen = currectDataPath.Length + 1;
            foreach (string item in Directory.GetFiles(currectDataPath))
            {
                const int endingLetterLength = 4;
                if (item.EndsWith(".txt"))
                {
                    int startAndEnd = (item.Length - startPathLen - endingLetterLength);
                    string fileName = item.Substring(startPathLen, startAndEnd);
                    usersComboBox.Items.Add(fileName);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool toTheNextForm = false;

            if (newUserRadioButton.Checked == true)
            {
                if (newUserTextBox.Text != "Name" && !usersComboBox.Items.Contains(newUserTextBox.Text))
                {
                    toTheNextForm = true;
                }
                else
                {
                    MessageBox.Show("Insert a new name");
                }
            }
            else if (usersComboBox.SelectedIndex > -1)
            {
                toTheNextForm = true;
            }
            else
            {
                MessageBox.Show("Chose one of the users.");
            }

            if (toTheNextForm == true)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void newUserTextBox_Enter(object sender, EventArgs e)
        {
            if (newUserTextBox.Text == "Name")
            {
                newUserTextBox.Text = "";
                newUserTextBox.ForeColor = Color.Black;
            }
        }

        private void newUserTextBox_Leave(object sender, EventArgs e)
        {
            if (newUserTextBox.Text == string.Empty)
            {
                newUserTextBox.Text = "Name";
                newUserTextBox.ForeColor = Color.Silver;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;            
        }
    }
}
