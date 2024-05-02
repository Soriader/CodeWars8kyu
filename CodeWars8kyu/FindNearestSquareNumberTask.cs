using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class FindNearestSquareNumberTask
    {
        public static int NearestSq(int n)
        {

            int lowerSqrt = (int)Math.Sqrt(n);
            int higherSqrt = lowerSqrt + 1;

            int lowerSquare = lowerSqrt * lowerSqrt;
            int higherSquare = higherSqrt * higherSqrt;

            int lowerDifference = n - lowerSquare;
            int higherDifference = higherSquare - n;

            if (lowerDifference < higherDifference)
            {
                return lowerSquare;
            }
            else
            {
                return higherSquare;
            }
        }
    }
}
//https://www.codewars.com/kata/5a805d8cafa10f8b930005ba/train/csharp