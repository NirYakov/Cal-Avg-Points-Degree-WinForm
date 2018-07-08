using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal_And_Utills_To_Degree_Points
{
    public struct CalculateAvg
    {
        private float m_MarkTotal ;
        private float m_PointsTotal;

        public float AverageTotal {
            get
            {
                float answer;

                try
                {
                    answer = m_MarkTotal / m_PointsTotal;
                }
                catch (Exception)
                {
                    answer = 0;                    
                }

                return answer; 
            }
        }

        public void AddMarkAndPoints(float i_Mark , float i_Points)
        {
            m_MarkTotal += i_Mark * i_Points;
            m_PointsTotal += i_Points;
        }

        public CalculateAvg AddMarkAndPoints(string i_MarkStr, string i_PointsStr)
        {
            float mark = float.Parse(i_MarkStr);
            float points = float.Parse(i_PointsStr);
            m_MarkTotal += mark * points ;
            m_PointsTotal += points; return this ;
        }        

        public override string ToString()
        {
            return string.Format("{0:0.00}", AverageTotal);
        }
    }
}