using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_And_Settings
{
    public class RightInputStrings
    {       
        public bool CourseName(string i_CourseNameInput)
        {
            return !string.IsNullOrEmpty(i_CourseNameInput);
        }

        public bool Mark(string i_Mark)
        {
            const byte minValue = 0, maxValue = 100;
            bool isRightNumberBetween0To100 = false;

            if (byte.TryParse(i_Mark, out byte inputNumber) && inputNumber >= minValue && inputNumber <= maxValue)
            {
                isRightNumberBetween0To100 = true;
            }

            return isRightNumberBetween0To100;
        }

        public bool Points(string i_Points)
        {
            const float minValue = 0, maxValue = 120; 
            bool isRightNumberBetween0To12 = false;

            if (float.TryParse(i_Points, out float inputNumber) && inputNumber >= minValue && inputNumber <= maxValue && inputNumber % 0.5f == 0)
            {
                isRightNumberBetween0To12 = true;
            }

            return isRightNumberBetween0To12;
        }
 
        public bool Year(string i_Year)
        {
            return !string.IsNullOrEmpty(i_Year);
        }
    }
}
