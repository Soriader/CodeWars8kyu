using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class PositiveSumTask
    {
        public static int PositiveSum(int[] arr)
        {
            int sum = 0;

            foreach (var item in arr)
            {
                if (item > 0)
                {
                    sum += item;
                }
            }
            return sum;

            //https://www.codewars.com/kata/5715eaedb436cf5606000381/train/csharp
        }
    }
}
