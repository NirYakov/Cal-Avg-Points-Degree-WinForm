using System;
using System.Windows.Forms;
using FormsActive;

namespace Degree_Average
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
            ActiveFroms active = new ActiveFroms();
            active.Run();
        }        
    }
}