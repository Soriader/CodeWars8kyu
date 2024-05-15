using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class NumberDrillsBlueAndRedMarblesTask
    {
        public static double GuessBlue(uint blueStart, uint redStart, uint bluePulled, uint redPulled)
        {
            double remainingBlue = blueStart - bluePulled;
            double remainingRed = redStart - redPulled;
            double totalRemaining = remainingBlue + remainingRed;

            return (double)remainingBlue / totalRemaining;

        }
    }
}
//https://www.codewars.com/kata/5862f663b4e9d6f12b00003b/train/csharp