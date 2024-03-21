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
            if (dadYears >= 2* sonYears) 
            {
                return dadYears - sonYears;
            }

            return 0;

        }
    }
}
