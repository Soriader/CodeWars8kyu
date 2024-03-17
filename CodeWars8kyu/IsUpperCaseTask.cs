using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class IsUpperCaseTask
    {
        public static bool IsUpperCase(string text)
        {
            var isUpper = text.Contains(text.ToUpper());

            if(isUpper)
            {
                return true;
            }

            return false;
        }

    }
}
//https://www.codewars.com/kata/56cd44e1aa4ac7879200010b/train/csharp