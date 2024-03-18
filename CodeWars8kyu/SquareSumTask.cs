using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class SquareSumTask
    {
        public static int SquareSum(int[] numbers)
        {
            int result = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                var exponentiation = (int)Math.Pow(numbers[i], 2);

                result += exponentiation;
            }

            return result;
        }
    }
}
//https://www.codewars.com/kata/515e271a311df0350d00000f/train/csharp