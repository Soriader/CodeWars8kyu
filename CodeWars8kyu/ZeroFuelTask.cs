using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class ZeroFuelTask
    {
        public static bool ZeroFuel(uint distanceToPump, uint mpg, uint fuelLeft)
        {

            if (mpg * fuelLeft < distanceToPump)
            {
                return false;
            }

            return true;
        }
    }
}
//https://www.codewars.com/kata/5861d28f124b35723e00005e/train/csharp
