using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class ReversedStringsTask
    {
        public static string ReversedStrings(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);

            //https://www.codewars.com/kata/5168bb5dfe9a00b126000018/train/csharp
        }
    }
}
