using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class GrasshopperSummationTask
    {
        public static int Summation(int num)
        {
            int result = 0;

            for (int i = 1; i <= num; i++)
            {
                result += i;
            }

            return result;
        }
    }
}
//https://www.codewars.com/kata/55d24f55d7dd296eb9000030/train/csharp