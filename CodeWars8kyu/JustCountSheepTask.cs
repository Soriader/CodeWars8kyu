using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class JustCountSheepTask
    {
        public static string CountSheep(int n)
        {
            string allSheep = "";

            for (int i = 1; i <= n; i++)
            {
                allSheep += $"{i} sheep...";
            }

            return allSheep;
        }
    }
}
//https://www.codewars.com/kata/5b077ebdaf15be5c7f000077/train/csharp