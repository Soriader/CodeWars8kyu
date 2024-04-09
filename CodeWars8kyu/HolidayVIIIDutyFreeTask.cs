using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class HolidayVIIIDutyFreeTask
    {
        public static int DutyFree(int normPrice, int Discount, int hol)
        {
            double discountAmount = (double)normPrice * Discount / 100.0;

            int bottles = (int)(hol / discountAmount);

            return bottles;
        }
    }
}
//https://www.codewars.com/kata/57e92e91b63b6cbac20001e5/train/csharp