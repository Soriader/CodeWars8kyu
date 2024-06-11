using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class AreArrowFunctionsOddTask
    {
        public static List<int> Odds(List<int> values) => values.Where(x => x % 2 != 0).ToList();
    }
}
//https://www.codewars.com/kata/559f80b87fa8512e3e0000f5/train/csharp