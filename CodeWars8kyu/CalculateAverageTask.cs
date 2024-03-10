using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class CalculateAverageTask
    {
        public static double FindAverage(double[] array)
        {
            if(array == null || array.Length == 0) return 0;
            var sum = array.Sum();
            var average = sum / array.Length;
            return average;
        }
    }
}
//https://www.codewars.com/kata/57a2013acf1fa5bfc4000921/train/csharp