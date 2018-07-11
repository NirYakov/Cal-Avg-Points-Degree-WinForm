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

        public float MarkTotal { get { return m_MarkTotal; } }

        public float PointsTotal { get { return m_PointsTotal; } }

        public void AddToTotals (float i_AddMarksTotal , float i_AddPointsTotal)
        {
            m_MarkTotal += i_AddMarksTotal;
            m_PointsTotal += i_AddPointsTotal;
        }

        public void AddMarkAndPoints(float i_Mark , float i_Points)
        {
            m_MarkTotal += i_Mark * i_Points;
            m_PointsTotal += i_Points;
        }

        public float ReachAvrg(float i_WantedMark , float i_GivenPoints)
        {
            float totalRightSide = (i_WantedMark * (m_PointsTotal + i_GivenPoints)) - m_MarkTotal;
            float answer = totalRightSide / i_GivenPoints;
            return answer;
        } 

        public CalculateAvg AddMarkAndPoints(string i_MarkStr, string i_PointsStr)
        {
            float mark = float.Parse(i_MarkStr);
            float points = float.Parse(i_PointsStr);
            m_MarkTotal += mark * points ;
            m_PointsTotal += points;
            return this ;
        }

        public void SubstractMarkAndPoints(string i_MarkStr, string i_PointsStr)
        {
            float mark = float.Parse(i_MarkStr);
            float points = float.Parse(i_PointsStr);
            m_MarkTotal -= mark * points;
            m_PointsTotal -= points;          
        }

        public override string ToString()
        {
            return string.Format("{0:0.00}", AverageTotal);
        }
    }
}