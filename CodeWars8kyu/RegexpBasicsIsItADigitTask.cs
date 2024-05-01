using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class RegexpBasicsIsItADigitTask
    {
        public static bool Digit(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return false; 
            }

            if (s.Length != 1)
            {
                return false; 
            }

            char c = s[0];
            return Char.IsDigit(c);
        }
    }
}
//https://www.codewars.com/kata/567bf4f7ee34510f69000032/train/csharp
