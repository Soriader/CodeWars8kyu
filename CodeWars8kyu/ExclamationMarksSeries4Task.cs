using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class ExclamationMarksSeries4Task
    {
        public static string Remove(string s)
        {
            s = s.Replace("!", "");
            return s + "!";
        }
    }
}
//https://www.codewars.com/kata/57faf12b21c84b5ba30001b0/train/csharp