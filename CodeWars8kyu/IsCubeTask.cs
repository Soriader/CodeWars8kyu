using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class IsCubeTask
    {
        public static bool IsCube(double volume, double side)
        {
            if(volume <= 0)
            {
                return false;
            }
            if(Math.Pow(side, 3) == volume)
            {
                return true;
            }

            return false;

        }
    }
}
//https://www.codewars.com/kata/58d248c7012397a81800005c/train/csharp