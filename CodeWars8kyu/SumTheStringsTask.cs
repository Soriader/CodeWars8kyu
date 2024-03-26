using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class SumTheStringsTask
    {
        public static string StringsSum(string s1, string s2)
        {
            int num1, num2;

            if (int.TryParse(s1, out num1) && int.TryParse(s2, out num2))
            {
                int result = num1 + num2;
                return result.ToString();
            }
            else if (int.TryParse(s1, out num1))
            {
                return num1.ToString();
            }
            else if (int.TryParse(s2, out num2))
            {
                return num2.ToString();
            }
            else
            {
                return "0";
            }
        }
    }
}
//https://www.codewars.com/kata/5966e33c4e686b508700002d/train/csharp