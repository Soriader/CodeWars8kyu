using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class BetterThanAverageTask
    {
        public static bool BetterThanAverage(int[] classPoints, int yourPoints)
        {
            int sum = 0;
            foreach (int points in classPoints)
            {
                sum += points;
            }

            sum += yourPoints;

            int average = sum / (classPoints.Length + 1);

            return yourPoints > average;
        }
    }
}
//https://www.codewars.com/kata/5601409514fc93442500010b/train/csharp