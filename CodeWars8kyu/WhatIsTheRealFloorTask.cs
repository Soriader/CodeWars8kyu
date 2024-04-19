using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class WhatIsTheRealFloorTask
    {
        public static int GetRealFloor(int n)
        {
            if (n > 0 && n < 13)
            {
                return n - 1;
            }
            else if (n > 13)
            {
                return n - 2;
            }
            else if (n == 13)
            {
                return n - 1; 
            }

            return n; 
        }

    }
}
//https://www.codewars.com/kata/574b3b1599d8f897470018f6/train/csharp