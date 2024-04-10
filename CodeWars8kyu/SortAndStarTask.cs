using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class SortAndStarTask
    {
        public static string TwoSort(string[] s)
        {
            string result = "";

            s = s.OrderBy(x => x, StringComparer.Ordinal).ToArray();

            var answer = s[0].ToCharArray();
            

            result = string.Join("***", answer);

            return result;
        }
    }
}
//https://www.codewars.com/kata/57cfdf34902f6ba3d300001e/train/csharp