using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class FindTheSlopeTask
    {
        public String Slope(int[] points)
        {
            var x = points[2] - points[0];
            var y = points[3] - points[1];

            if(x == 0) return "undefined";
            if(y == 0) return "0";

            return (y/x).ToString();
        }
    }
}
//https://www.codewars.com/kata/55a75e2d0803fea18f00009d/train/csharp