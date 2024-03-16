using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class FindNeedleTask
    {
        public static string FindNeedle(object[] haystack)
        {
            for (int i = 0; i < haystack.Length; i++)
            {
                if(haystack[i] != null && haystack[i].ToString().ToLower() == "needle")
                {
                    return $"found the needle at position {i}";
                }
            }

            return "";
        }
    }
}
//https://www.codewars.com/kata/56676e8fabd2d1ff3000000c/train/csharp