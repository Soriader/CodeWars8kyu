using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class RemoveAllExclamationMarksTask
    {
        public static string RemoveExclamationMarks(string s)
        {
            s = s.Replace("!", "");
            return s;
        }
    }
}
