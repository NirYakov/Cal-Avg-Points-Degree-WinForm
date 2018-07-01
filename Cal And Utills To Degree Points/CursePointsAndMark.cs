using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal_And_Utills_To_Degree_Points
{
    public struct CursePointsAndMark
    {
        private readonly string r_CurseName;
        private float m_Points;
        private float m_Mark;

        public CursePointsAndMark(string i_CurseName, float i_Points, float i_Mark)
        {
            r_CurseName = i_CurseName;
            m_Points = i_Points;
            m_Mark = i_Mark;
        }

        public float Points
        {
            get { return m_Points; }
            set { m_Points = value; }
        }

        public float Mark
        {
            get { return m_Mark; }
            set { m_Mark = value; }
        }

        public string CurseName
        {
            get { return r_CurseName; }
        }

    }
}