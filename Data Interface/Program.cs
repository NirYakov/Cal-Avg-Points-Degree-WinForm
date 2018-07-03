using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;

namespace Data_Interface
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ActiveMethod();
        }

        static public void ActiveMethod()
        {
                FileCreate();

            OpenningForm form1 = new OpenningForm();

            
            if (form1.ShowDialog() == DialogResult.OK)
            {

            string nameOfFile;

                if (form1.IsHaveNewUser() == true)
                {
                    nameOfFile = form1.NewUser;
                    FileStream fs =  File.OpenWrite(string.Format(@"UsersData\{0}.txt",nameOfFile));
                    fs.Close();
                }
                else
                {
                    nameOfFile = form1.ComboChosen;
                }

                MessageBox.Show(string.Format(nameOfFile));

                //testFillDataToTxtAndListView();


                // Application.Run(new Form2());

                MainForm form2 = new MainForm(nameOfFile);
                form2.ShowDialog();
                form2.SaveNewData();

                // Application.Run(new Form1());
            }

        }

        static public void testFillDataToTxtAndListView()
        {
            string[] nirCurses = { "Prog C,79,5,1,1", "Algo A,83,4,2,2", ".Net C#,93,3,2,2", "Assmbely,91,3,2,1" };

            // FileStream fs = File.OpenWrite(@"UsersData\Nir y.txt");

            File.WriteAllLines(@"UsersData\Nir y.txt", nirCurses);

        }


        static public void FileCreate()
        {
            //string dataUserPath = "UsersData";

            // if(Directory)

            if (!Directory.Exists(@"./UsersData"))
            {
                Directory.CreateDirectory("UsersData");
                MessageBox.Show("New Dir");
            }
            else
            {
                // MessageBox.Show("Have this dir already");
            }

            FileStream fs;

            if (!File.Exists(@"UsersData\Ran z.txt"))
            {
                fs = File.OpenWrite(@"UsersData\Ran z.txt");
                fs.Close();
            }

            if (!File.Exists(@"UsersData\Nir y.txt"))
            {
                fs = File.OpenWrite(@"UsersData\Nir y.txt");
                fs.Close();
            }
        }
    }
}
