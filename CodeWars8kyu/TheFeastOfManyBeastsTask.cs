using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class TheFeastOfManyBeastsTask
    {
        public static bool Feast(string beast, string dish)
        {
            var beastToChar = beast.ToCharArray();

            var firstLetter = beastToChar[0];
            var lastLetter = beastToChar[beastToChar.Length - 1];

            var dishFirstLetter = dish.StartsWith(firstLetter) && dish.EndsWith(lastLetter);

            if (dishFirstLetter)
            {
                return true;
            }

            return false;
        }
    }
}
//https://www.codewars.com/kata/5aa736a455f906981800360d/train/csharp