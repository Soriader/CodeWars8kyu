using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class DifferenceOfVolumesOfCuboidsTask
    {
        public static int FindDifference(int[] a, int[] b)
        {
            int resultA = a.Aggregate((x, y) => x * y);
            int resultB = b.Aggregate((x, y) => x * y);

            if(resultA > resultB)
            {
                return resultA - resultB;
            }
            else
            {
                return resultB - resultA;
            }
        }
    }
}
//https://www.codewars.com/kata/58cb43f4256836ed95000f97/train/csharp