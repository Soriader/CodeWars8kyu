using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class PillarsTask
    {
        public static int Pillars(int numPill, int dist, int width)
        {
            int result;
            if (numPill <= 1)
            {
                result = 0;
            }
            else
            {
                result = (dist * (numPill - 1) * 100) + (width * (numPill - 2));
            }
            return result;
        }
    }
}
//https://www.codewars.com/kata/5bb0c58f484fcd170700063d/train/csharp