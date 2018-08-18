﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_And_Settings
{
    public struct CalculateAvg
    {
        private float m_MarkTotal;
        private float m_PointsTotal;

        public float AverageTotal
        {
            get
            {
                float answer;

                if (m_PointsTotal > 0)
                {
                    answer = m_MarkTotal / m_PointsTotal;
                }
                else
                {
                    answer = 0;
                }       
                
                return answer;
            }
        }

        public float MarkTotal { get { return m_MarkTotal; } }

        public float PointsTotal { get { return m_PointsTotal; } }

        public float ReachAvrg(float i_WantedMark, float i_GivenPoints)
        {
            float totalRightSide = (i_WantedMark * (m_PointsTotal + i_GivenPoints)) - m_MarkTotal;
            float answer;
            if (i_GivenPoints > 0)
            {
                answer = totalRightSide / i_GivenPoints;
            }
            else
            {
                answer = 0;
            }

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
            AddMarkAndPoints(mark, points);
            return this;
        }

        public void SubstractMarkAndPoints(string i_MarkString, string i_PointsString)
        {
            parseTwoNumbers(i_MarkString, out float mark, i_PointsString, out float points);
            SubstractMarkAndPoints(mark, points);
        }

        public void SubstractMarkAndPoints(float i_Mark, float i_Points)
        {
            AddMarkAndPoints(i_Mark, (i_Points * -1f));
        }

        public override string ToString()
        {
            return string.Format("{0:00.00}", AverageTotal);
        }

        public void ChangeMarkAndTotal(string i_MarkString, string i_PointsString)
        {
            //float markOffset = float.Parse(i_Mark);
            //float points = float.Parse(i_Points);
            parseTwoNumbers(i_MarkString, out float markOffset, i_PointsString, out float points);

            m_MarkTotal += markOffset * points;
        }

        private static void parseTwoNumbers(string i_MarkString, out float i_Mark, string i_PointsString, out float i_Points)
        {
            i_Mark = float.Parse(i_MarkString);
            i_Points = float.Parse(i_PointsString);
        }

        public static float DifferenceValueTo100(string i_MarkString, string i_PointsString)
        {
            const float maxMark = 100f;
            parseTwoNumbers(i_MarkString, out float mark, i_PointsString, out float points);
            float differenceInMark = maxMark - mark;
            float differnceValue = differenceInMark * points;

            return differnceValue;
        }

        public float ReplaceMark(float i_WantedMark, float i_Mark, float i_Points)
        {
            float markDiffrence = i_WantedMark - i_Mark;
            float diffrenceValue = markDiffrence * i_Points;
            float markTotal = m_MarkTotal + diffrenceValue;
            float answerTotalAverage = markTotal / m_PointsTotal;
            return answerTotalAverage;
        }
    }
}