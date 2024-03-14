using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class GradeBookTask
    {
        public static char GetGrade(int s1, int s2, int s3)
        {
            int[] numbers = { s1, s2, s3 };
            double average = (int)numbers.Average();

            if (average >= 60 && average <= 69)
            {
                return 'D';
            }

            if (average >= 70 && average <= 79)
            {
                return 'C';
            }
            if (average >= 80 && average <= 89)
            {
                return 'B';
            }
            if (average >= 90 && average <= 100)
            {
                return 'A';
            }

            return 'F';
        }
    }
}
//https://www.codewars.com/kata/55cbd4ba903825f7970000f5/train/csharp