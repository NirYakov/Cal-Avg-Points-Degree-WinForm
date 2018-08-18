using System;
using System.Windows.Forms;
using Logic_And_Settings;

namespace FormsActive
{
    public partial class FormChangeMark : Form
    {
        private static FormChangeMark s_Instance = null;
        private CalculateAvg m_AverageChange;
        private float m_PointsOfCourse;
        private byte m_OldMark;

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

        public DialogResult ShowDialog(string i_CourseName, byte i_Mark, CalculateAvg i_AverageMark ,string i_Points)
        {
            m_PointsOfCourse = float.Parse(i_Points);
            m_AverageChange = i_AverageMark;
            m_OldMark = i_Mark;
            numericUpDownMarkToChange.Value = m_OldMark;
            labelCourseName.Text = i_CourseName;
            updateAverageLabel();
            DialogResult result = ShowDialog();
            return result;
        }

        public byte LastValue
        {
            get { return (byte)numericUpDownMarkToChange.Value; }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;          
        }

        private void numericUpDownMarkToChange_ValueChanged(object sender, EventArgs e)
        {
            updateAverageLabel();
        }

        private void updateAverageLabel()
        {
            float changedAverage = m_AverageChange.ReplaceMark((float)numericUpDownMarkToChange.Value, m_OldMark, m_PointsOfCourse);
            labelChangeMark.Text = string.Format("{0:0.00}", changedAverage);
        }
    }
}
