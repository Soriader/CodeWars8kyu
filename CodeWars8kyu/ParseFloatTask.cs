using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class ParseFloatTask
    {
        public static double? ParseF(object s = null)
        {
            if (s == null)
            {
                return null;
            }

            if (double.TryParse(s.ToString(), out double resultOfParse))
            {
                return resultOfParse;
            }
            else
            {
                return null;
            }

        }
    }
}
//https://www.codewars.com/kata/57a386117cb1f31890000039/train/csharp