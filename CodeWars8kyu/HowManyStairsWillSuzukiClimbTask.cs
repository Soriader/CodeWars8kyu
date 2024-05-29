using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class HowManyStairsWillSuzukiClimbTask
    {
        public static long StairsIn20(int[][] stairs)
        {
            long result = 0;

            foreach (var stair in stairs)
            {
                result += stair.Aggregate((x, y) => x + y);
            }

            return result*20;
        }
    }
}
//https://www.codewars.com/kata/56fc55cd1f5a93d68a001d4e/train/csharp