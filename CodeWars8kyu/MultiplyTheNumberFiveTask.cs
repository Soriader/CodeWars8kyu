using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class MultiplyTheNumberFiveTask
    {
        public static int Multiply(int number)
        {
            if (number == 0)
            {
                return 0;
            }

            int digitsCount = Math.Abs(number).ToString().Length;

            int result = (int)(number * Math.Pow(5, digitsCount));

            return result;
        }
    }
}
//https://www.codewars.com/kata/5708f682c69b48047b000e07/train/csharp