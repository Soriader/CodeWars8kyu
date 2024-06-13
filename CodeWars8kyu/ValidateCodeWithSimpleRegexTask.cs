using CodeWars8kyu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class ValidateCodeWithSimpleRegexTask
    {
        public static bool ValidateCode(string code)
        {
            if(string.IsNullOrEmpty(code)) return false;

            var checkTheNumber = code.ToCharArray();

            if (checkTheNumber[0] == '1' || checkTheNumber[0] == '2' || checkTheNumber[0] == '3')
            {
                return true;
            }

            return false;
        }
    }
}
//https://www.codewars.com/kata/56a25ba95df27b7743000016/train/csharp