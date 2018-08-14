using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal_Avrg_To_Degree_Points
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

        public float ReachAvrg(float i_WantedMark , float i_GivenPoints)
        {
            float totalRightSide = (i_WantedMark * (m_PointsTotal + i_GivenPoints)) - m_MarkTotal;
            float answer = totalRightSide / i_GivenPoints;
            return answer;
        } 

        public void AddMarkAndPoints(float i_Mark, float i_Points)
        {
            m_MarkTotal += i_Mark * i_Points;
            m_PointsTotal += i_Points;
        }

        public CalculateAvg AddMarkAndPoints(string i_MarkString, string i_PointsString)
        {
            parseTwoNumbers(i_MarkString, out float mark, i_PointsString, out float points);
            m_MarkTotal += mark * points ;
            m_PointsTotal += points;
            return this;
        }

        public void SubstractMarkAndPoints(string i_MarkString, string i_PointsString)
        {           
            parseTwoNumbers(i_MarkString, out float mark, i_PointsString, out float points);
            m_MarkTotal -= mark * points;
            m_PointsTotal -= points;          
        }

        public override string ToString()
        {
            return string.Format("{0:0.00}", AverageTotal);
        }        

        public void ChangeMarkAndTotal(string i_MarkString, string i_PointsString)
        {
            //float markOffset = float.Parse(i_Mark);
            //float points = float.Parse(i_Points);
            parseTwoNumbers(i_MarkString, out float markOffset, i_PointsString, out float points);

            m_MarkTotal += markOffset * points;
        }

        private static void parseTwoNumbers( string i_MarkString,out float i_Mark ,string i_PointsString ,  out float i_Points)
        {
            i_Mark = float.Parse(i_MarkString);
            i_Points = float.Parse(i_PointsString);
        }

        // Add Method Dist to get the best value course

        public static float DifferenceValueTo100(string i_MarkString , string i_PointsString)
        {
            const float maxMark = 100f;
            parseTwoNumbers(i_MarkString, out float mark, i_PointsString , out float points);
            float differenceInMark = maxMark - mark;
            float differnceValue = differenceInMark * points;

            return differnceValue;
        }

    }
}