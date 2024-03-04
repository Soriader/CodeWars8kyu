using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public static class RentalCarTask
    {
        public static int RentalCarCost(int d)
        {
            if (d == 1 || d == 2)
            {
                return d * 40;
            }
            if (d <= 6)
            {
                return d * 40 - 20;
            }
            if (d >= 7)
            {
                return d * 40 - 50;
            }

            return d;
        }
    }
}
//https://www.codewars.com/kata/568d0dd208ee69389d000016/train/csharp
