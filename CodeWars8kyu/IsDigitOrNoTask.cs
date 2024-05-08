using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class IsDigitOrNoTask
    {
        public static bool IsDigit(string s)
        {

            if (string.IsNullOrEmpty(s))
            {
                return false;
            }

            s = s.Trim();

            if (s.Count(c => c == '-') > 1)
            {
                return false;
            }

            if (s.Count(c => c == '.' || c == ',') > 1)
            {
                return false;
            }
            return Regex.IsMatch(s, @"^[-+]?[0-9]*\.?[0-9]+$");
        }
    }
}
//https://www.codewars.com/kata/57126304cdbf63c6770012bd/train/csharp