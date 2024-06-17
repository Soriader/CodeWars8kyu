using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class NBAFullTask
    {
        public static double NbaExtrap(double ppg, double mpg)
        {
            if(ppg == 0 &&  mpg == 0)
            {
                return 0;
            }

            return Math.Round(ppg * 48 / mpg, 1);
        }
    }
}
//https://www.codewars.com/kata/587c2d08bb65b5e8040004fd/train/csharp