using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class CompareWithinMarginTask
    {
        public static int CloseCompare(double a, double b, double margin = 0)
        {
            if (Math.Abs(a - b) <= margin) return 0;
            return a < b ? -1 : 1;
        }
    }
}
//https://www.codewars.com/kata/56453a12fcee9a6c4700009c/train/csharp