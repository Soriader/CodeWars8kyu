using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class RemoveAnExclamationTask
    {
        public static string Remove(string s)
        {

            if (s.EndsWith("!"))
            {
                s = s.Remove(s.Length - 1);
            }

            return s;
        }
    }
}
//https://www.codewars.com/kata/57fae964d80daa229d000126/train/csharp