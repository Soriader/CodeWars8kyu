using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class FilterOutTheGeeseTask
    {
        public static IEnumerable<string> GooseFilter(IEnumerable<string> birds)
        {
            string[] geese = new string[] { "African", "Roman Tufted", "Toulouse", "Pilgrim", "Steinbacher" };

            var noGeese = birds.Where(b => !geese.Contains(b)).ToList();

            return noGeese;
        }
    }
}
//https://www.codewars.com/kata/57ee4a67108d3fd9eb0000e7/train/csharp