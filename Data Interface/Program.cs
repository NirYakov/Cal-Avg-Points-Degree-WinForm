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

            FileCreate();

            Application.Run(new Form2());

            // Application.Run(new Form1());
            
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
                MessageBox.Show("Have this dir already");
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
