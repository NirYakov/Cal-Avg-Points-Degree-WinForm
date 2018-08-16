using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal_And_Utills_To_Degree_Points
{
    public class RightInputStrings
    {

        public bool CourseName(string i_CourseNameInput)
        {
            return true;
        }

        public bool Mark(string i_Mark)
        {
            const float minValue = 0, maxValue = 12;
            bool isRightNumberBetween0To100 = false;

            if (byte.TryParse(i_Mark, out byte inputNumber) && inputNumber >= minValue && inputNumber <= maxValue)
            {
                isRightNumberBetween0To100 = true;
            }

            return isRightNumberBetween0To100;
        }

        public bool Points(string i_Points)
        {
            const float minValue = 0, maxValue = 12; 
            bool isRightNumberBetween0To12 = false;
            
            

            return isRightNumberBetween0To12;
        }

        public void Amm<T>(string i_InputString,T varr, T minValue , T maxValue) where T : struct
        {
            bool answer = false;

            if (T.TryParse(i_InputString, out T inputNumber) && inputNumber >= minValue && inputNumber <= maxValue)
            {
                answer = true;
            }

            return answer;
        }

        public bool Year(string i_Year)
        {
            return true;
        }
    }
}
