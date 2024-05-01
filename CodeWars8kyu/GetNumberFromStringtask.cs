using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class GetNumberFromStringTask
    {
        public static int GetNumberFromString(string s)
        {
            var result = s.ToCharArray();
            List<char> digits = new List<char>();

            for (int i = 0; i < result.Length; i++)
            {
                if (Char.IsDigit(result[i]))
                {
                    digits.Add(result[i]);
                }
            }

            int number = 0;
            foreach (char digit in digits)
            {
                number = number * 10 + (digit - '0');
            }

            return number;
        }
    }
}
//https://www.codewars.com/kata/57a37f3cbb99449513000cd8/train/csharp