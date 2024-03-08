using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodeWars8kyu
{
    public class IsItEvenTask
    {
        public static bool IsEven(double n)
        {
            if (n % 2 == 0)
            {
                return true;
            }

            return false;

        }
    }
}
//https://www.codewars.com/kata/555a67db74814aa4ee0001b5/train/csharp