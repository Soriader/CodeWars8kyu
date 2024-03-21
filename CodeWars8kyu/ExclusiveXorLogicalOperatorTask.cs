using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class ExclusiveXorLogicalOperatorTask
    {
        public static bool Xor(bool a, bool b)
        {
            if(a == true && b == false || a == false && b == true)
            {
                return true;
            }

            return false;
        }
    }
}
//https://www.codewars.com/kata/56fa3c5ce4d45d2a52001b3c/train/csharp