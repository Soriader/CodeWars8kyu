using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class TotalPointsTest
    {
        public static int TotalPoints(string[] games)
        {
            int score = 0;

            for (int i = 0; i < games.Length; i++)
            {
                string[] parts = games[i].Split(':');
                int x = int.Parse(parts[0]);
                int y = int.Parse(parts[1]);

                if (x > y)
                {
                    score += 3;
                }
                else if (x == y)
                {
                    score += 1;
                }
            }

            return score;
        }
    }
}
//https://www.codewars.com/kata/5bb904724c47249b10000131/train/csharp