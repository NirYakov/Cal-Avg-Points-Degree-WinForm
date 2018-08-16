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

            if (float.TryParse(i_Points, out float inputNumber) && inputNumber >= minValue && inputNumber <= maxValue)
            {
                isRightNumberBetween0To12 = true;
            }

            return isRightNumberBetween0To12;
        }

        public void Haaha <T> (T lol) where T : struct , IFormattable , IConvertible

        {
            bool obj = T.TryPrase("5.5", out T ok);


        }
                
        public bool Year(string i_Year)
        {
            return true;
        }
    }
}
