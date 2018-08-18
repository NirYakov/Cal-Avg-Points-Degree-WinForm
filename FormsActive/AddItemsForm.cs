using System;
using System.Drawing;
using System.Windows.Forms;
using Logic_And_Settings;

namespace FormsActive
{
    public partial class AddItemsForm : Form
    {
        public event Action<string[]> AddCurse;
        private static AddItemsForm s_Instance = null;
        private static readonly RightInputStrings sr_CheckInput = null;
        private bool m_IsRightCourseName = false, m_IsRightMark = false, m_IsRightPoints = false, m_IsRightYear = false;

        private delegate bool currentToActive(string i_InputString);

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

        private string semesterString
        {
            get
            {
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

                return semesterStr;
            }
        }

        private string[] dataPackegeToArry()
        {
            string[] newData = new string[5];
            newData[(int)eSubItem.CourseName] = textBoxCourseName.Text;
            newData[(int)eSubItem.Mark] = textBoxMark.Text;
            newData[(int)eSubItem.Points] = textBoxPoints.Text;
            newData[(int)eSubItem.Year] = textBoxYear.Text;
            newData[(int)eSubItem.Semseter] = semesterString;
            return newData;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (m_IsRightCourseName && m_IsRightMark && m_IsRightPoints && m_IsRightYear)
            {
                m_IsRightCourseName = m_IsRightMark = m_IsRightPoints = m_IsRightYear = false;
                string[] newData = dataPackegeToArry();
                clearAllTextBoxes();
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
            m_IsRightCourseName = checkAndColorIfRightInput(sender, sr_CheckInput.CourseName, panelWarnningName);
        }

        private void textBoxMark_Leave(object sender, EventArgs e)
        {
            m_IsRightMark = checkAndColorIfRightInput(sender, sr_CheckInput.Mark, panelWarnningMark);
        }

        private void textBoxPoints_Leave(object sender, EventArgs e)
        {
            m_IsRightPoints = checkAndColorIfRightInput(sender, sr_CheckInput.Points, panelWarnningPoints);
        }

        private void textBoxYear_Leave(object sender, EventArgs e)
        {
            m_IsRightYear = checkAndColorIfRightInput(sender, sr_CheckInput.Year, panelWarnningYear);
        }

        private void AddItemsForm_Deactivate(object sender, EventArgs e)
        {
            clearAllTextBoxes();
            radioButton1.Checked = true;
        }

       

        private void clearAllTextBoxes()
        {
            textBoxCourseName.Text = textBoxMark.Text = textBoxPoints.Text = textBoxYear.Text = string.Empty;
            panelWarnningName.BackColor = panelWarnningMark.BackColor =
                panelWarnningPoints.BackColor = panelWarnningYear.BackColor = Color.Transparent;
        }

        private bool checkAndColorIfRightInput(object sender, currentToActive i_Del_ActiveChecking, Panel i_Panel)
        {
            TextBox textBox = sender as TextBox;
            bool isRightInput = false;

            if (textBox != null)
            {
                isRightInput = i_Del_ActiveChecking(textBox.Text);

                if (isRightInput)
                {
                    i_Panel.BackColor = Color.Green;
                }
                else
                {
                    i_Panel.BackColor = textBox.ForeColor = Color.Red;
                }
            }

            return isRightInput;
        }

        private void resetColorToBlackText(object sender, EventArgs e)
        {
            Control controller = sender as Control;

            if (controller != null)
            {
                controller.ForeColor = Color.Black;
            }
        }
    }
}
