using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class DoubleCharTask
    {
        public static string DoubleChar(string s)
        {
            string doubleLetter = "";
            char[] toChar = s.ToCharArray();

            for (int i = 0; i < toChar.Length; i++)
            {
                doubleLetter += toChar[i];
                doubleLetter += toChar[i];
            }

            return doubleLetter;
        }
    }
}
//https://www.codewars.com/users/Soriader/completed_solutions