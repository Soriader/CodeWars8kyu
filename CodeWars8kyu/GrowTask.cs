using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class GrowTask
    {
        public static int Grow(int[] x)
        {
            int result = 1;

            for (int i = 0; i < x.Length; i++)
            {
                result *= x[i];

            }

            return result;
        }
    }
}
//https://www.codewars.com/kata/57f780909f7e8e3183000078/train/csharp