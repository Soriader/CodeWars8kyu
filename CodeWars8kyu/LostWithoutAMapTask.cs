using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class LostWithoutAMapTask
    {
        public static int[] Maps(int[] x)
        {

            for (int i = 0; i < x.Length; i++)
            {
                 x[i] *= 2;
            }

            return x;
        }
    }
}
//https://www.codewars.com/kata/57f781872e3d8ca2a000007e/train/csharp