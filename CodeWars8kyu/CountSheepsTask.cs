using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class CountSheepsTask
    {
        public static int CountSheeps(bool[] sheeps)
        {
            int allSheeps = 0;

            foreach (var sheep in sheeps)
            {
                if (sheep)
                {
                    allSheeps++;
                }
            }

            return allSheeps;
        }
    }
}
//https://www.codewars.com/users/Soriader/completed_solutions