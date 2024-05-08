using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class UEFAEUROTask
    {
        public static string UefaEuro2016(string[] teams, int[] scores)
        {
            if (scores[0] == scores[1])
            {
                return $"At match {teams[0]} - {teams[1]}, teams played draw.";
            }

            if (scores[0] > scores[1])
            {
                return $"At match {teams[0]} - {teams[1]}, {teams[0]} won!";
            }
            else
            {
                return $"At match {teams[0]} - {teams[1]}, {teams[1]} won!";
            }

        }
    }
}
//https://www.codewars.com/kata/57613fb1033d766171000d60/train/csharp