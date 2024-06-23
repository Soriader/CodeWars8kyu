using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class EvilOrOdiousTask
    {
        public static string Evil(int n)
        {
            string binary = Convert.ToString(n, 2);

            int countOfOnes = binary.Count(c => c == '1');

            if (countOfOnes % 2 == 0)
            {
                return "It's Evil!";
            }
            else
            {
                return "It's Odious!";
            }
        }
    }
}
//https://www.codewars.com/kata/56fcfad9c7e1fa2472000034/train/csharp