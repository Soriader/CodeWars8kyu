using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class SuperDuperEasyTask
    {
        public static string Problem(String a)
        {
            double number;

            if (double.TryParse(a, out number))
            {
                return (number * 50 + 6).ToString();
            }
            return "Error";

        }
    }
}
//https://www.codewars.com/kata/55a5bfaa756cfede78000026/train/csharp