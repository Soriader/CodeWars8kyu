using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class RemoveAllExclamationMarksFromTheEndTask
    {
        public static string Remove(string s)
        {
            return s.TrimEnd('!');
        }
    }
}
//https://www.codewars.com/kata/57faece99610ced690000165/train/csharp