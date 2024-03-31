using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class LoveDetectorTask
    {
        public static bool Lovefunc(int flower1, int flower2)
        {
            if((flower1 % 2 == 0 && flower2 % 2 != 0) || (flower1 % 2 != 0 && flower2 % 2 == 0))
            {
                return true;
            }
            else {  return false; }
        }
    }
}
//https://www.codewars.com/kata/555086d53eac039a2a000083/train/csharp