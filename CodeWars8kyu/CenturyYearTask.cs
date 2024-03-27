using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class CenturyYearTask
    {
        public static int СenturyYear(int year)
        {
            int result = 0;
            double century = year / 100;
            result = (int)century;

            if (year % 100 != 0)
            {
                result = (int)century + 1;
            }
            return result;
        }
    }
}
//https://www.codewars.com/kata/5a3fe3dde1ce0e8ed6000097/train/csharp