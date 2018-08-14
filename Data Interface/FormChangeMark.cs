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
    public partial class FormChangeMark : Form
    {
        private static FormChangeMark s_Instance = null;

        private FormChangeMark()
        {
            InitializeComponent();
        }

        public static FormChangeMark GetInstanceOfFormChangeMark()
        {
            if (s_Instance == null)
            {
                s_Instance = new FormChangeMark();
            }

            return s_Instance;
        }

        public DialogResult ShowDialog(string i_CourseName, byte i_Mark)
        {
            numericUpDownMarkToChange.Value = i_Mark;
            labelCourseName.Text = i_CourseName;
            DialogResult result = ShowDialog();
            return result;
        }

        public byte LastValue
        {
            get { return (byte)numericUpDownMarkToChange.Value; }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;          
        }
    }
}
