using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class TwiceAsOldTask
    {
        public static int TwiceAsOld(int dadYears, int sonYears)
        {
            int ageDifference = dadYears - sonYears;

            if (ageDifference >= sonYears)
            {
                return ageDifference - sonYears;
            }
            else
            {
                return sonYears * 2 - dadYears;
            }

        }
    }
}
//https://www.codewars.com/kata/5b853229cfde412a470000d0/train/csharp