using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class RegexCountLowercaseLettersTask
    {
        public static int LowercaseCountCheck(string s)
        {
            int iterator = 0;
            var result = s.ToCharArray();

            for (int i = 0; i < result.Length; i++)
            {
                if (char.IsLower(result[i]))
                {
                    iterator++;
                }
            }

            return iterator;
        }
    }
}
//https://www.codewars.com/kata/56a946cd7bd95ccab2000055/train/csharp