using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class AppleTurnoverTask
    {
        public static string Apple(object n)
        {
            double num = Convert.ToDouble(n);

            double result = num * num;

            if (result > 1000)
            {
                return "It's hotter than the sun!!";
            }
            else
            {
                return "Help yourself to a honeycomb Yorkie for the glovebox.";
            }
        }
    }
}
//https://www.codewars.com/kata/580a094553bd9ec5d800007d/train/csharp