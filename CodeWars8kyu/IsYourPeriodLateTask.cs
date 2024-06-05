using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class IsYourPeriodLateTask
    {
        public static bool PeriodIsLate(DateTime last, DateTime today, int cycleLength)
        {
            var checkDays = today - last;
            int daysDifference = checkDays.Days;

            if (daysDifference > cycleLength)
            {
                return true;
            }

            return false;

        }
    }
}
//https://www.codewars.com/kata/578a8a01e9fd1549e50001f1/train/csharp