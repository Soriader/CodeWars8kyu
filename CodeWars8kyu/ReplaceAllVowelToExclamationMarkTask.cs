using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class ReplaceAllVowelToExclamationMarkTask
    {
        public static string Replace(string s)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in s)
            {
                if ("aeiouAEIOU".Contains(c))
                {
                    result.Append("!");
                }
                else
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
    }
}
//https://www.codewars.com/kata/57fb09ef2b5314a8a90001ed/train/csharp