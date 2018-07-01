using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal_And_Utills_To_Degree_Points
{
    public class CalculateAvg
    {
        private readonly LinkedList<CursePointsAndMark> r_DataList = new LinkedList<CursePointsAndMark>();
        private string m_StudentName;

        public string StudentName
        {
            get { return m_StudentName; }
        }

        public void AddCourse(string i_CouseName, float i_Mark, float i_Points)
        {
            r_DataList.AddLast(new CursePointsAndMark(i_CouseName, i_Mark, i_Points));
        }

        private bool RemoveCourse(string i_CouseName) // Dont use, not have the remove to this.
        {
            bool isHere = false;

            foreach (CursePointsAndMark item in r_DataList)
            {
                if (i_CouseName == item.CurseName)
                {
                    isHere = true;
                    break;

                    // r_DataList.Remove();
                }
            }

            return isHere;
        }

        public float Avg
        {
            get
            {
                float totalMarks = 0, totalPoints = 0;
                foreach (CursePointsAndMark item in r_DataList)
                {
                    totalMarks += item.Mark;
                    totalPoints += item.Points;
                }

                float avgMark = totalMarks / totalPoints;

                return avgMark;
            }
        }
    }
}
