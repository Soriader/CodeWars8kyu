using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class ConvertNumberToReversedArrayOfDigitsTask
    {
        public static long[] Digitize(long n)
        {
            if(n == 0)
            {
                return new long[] { 0 };
            }
            var numbers = n.ToString().Select(c => long.Parse(c.ToString())).Reverse();
            List<long> result = new List<long>(numbers);
            return result.ToArray();

        }
    }
}
//https://www.codewars.com/kata/5583090cbe83f4fd8c000051/train/csharp