using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class SumOfDifferencesInArrayTask
    {
        public static int SumOfDifferences(int[] arr)
        {
            if (arr == null || arr.Length == 0) return 0;

            int result = 0;
            var goodOrder = arr.OrderByDescending(n => n).ToArray();

            for (int i = 0; i < goodOrder.Length - 1; i++)
            {
                result += goodOrder[i] - goodOrder[i+1];
            }

            return result;
        }
    }
}
//https://www.codewars.com/kata/5b73fe9fb3d9776fbf00009e/train/csharp