using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace FormsActive
{
    public class ActiveFroms
    {
        public ActiveFroms()
        {

        }

        public void Run()
        {
            activeForm();
        }

        private void activeForm()
        {
            fileCreate();
            OpenningForm form1 = new OpenningForm();
            if (form1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    form1.UserEnternce();
                    string nameOfUser = form1.UserName;
                    form1.Dispose();
                    MessageBox.Show(nameOfUser);
                    MainForm form2 = new MainForm(nameOfUser);
                    form2.ShowDialog();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error , please try again later.");
                }
            }
        }

        private void fileCreate()
        {
            if (!Directory.Exists(@"./UsersData"))
            {
                Directory.CreateDirectory("UsersData");
            }
        }

    }
}
