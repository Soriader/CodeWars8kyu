using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class ParseIntToCharTask
    {
        public static int GetAge(string inputString)
        {
            var digits = inputString.Where(char.IsDigit);

            if (digits.Any())
            {
                return int.Parse(digits.First().ToString());
            }

            return 0;
        }
    }
}
//https://www.codewars.com/kata/557cd6882bfa3c8a9f0000c1/train/csharp