using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class StringCleaningTask
    {
        public static string StringClean(string s)
        {
            string result = "";

            foreach (char c in s)
            {
                if (!char.IsDigit(c))
                {
                    result += c;
                }
            }

            return result;
        }
    }
}
