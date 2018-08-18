using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_And_Settings
{
    public struct CourseDiffrence : IComparable<CourseDiffrence>
    {
        private readonly string r_CourseName;
        private readonly float r_DiffrenceNumber;

        public CourseDiffrence(string r_CourseName, float r_DiffrenceNumber)
        {
            this.r_CourseName = r_CourseName ?? throw new ArgumentNullException(nameof(r_CourseName));
            this.r_DiffrenceNumber = r_DiffrenceNumber;
        }

        public float DiffrenceNumber { get { return r_DiffrenceNumber; } }
        public string CourseName { get { return r_CourseName; } }

        public static bool operator >(CourseDiffrence courseDiffrenceLeft, CourseDiffrence courseDiffrenceRight)
        {
            return courseDiffrenceLeft.DiffrenceNumber > courseDiffrenceRight.DiffrenceNumber;
        }

        public static bool operator <(CourseDiffrence courseDiffrenceLeft, CourseDiffrence courseDiffrenceRight)
        {
            return courseDiffrenceLeft.DiffrenceNumber < courseDiffrenceRight.DiffrenceNumber;
        }

        public int CompareTo(CourseDiffrence other)
        {
            int answer = 0;

            if (r_DiffrenceNumber > other.r_DiffrenceNumber)
            {
                answer = -1;
            }
            else if (r_DiffrenceNumber < other.r_DiffrenceNumber)
            {
                answer = 1;
            }

            return answer;
        }
    }
}
