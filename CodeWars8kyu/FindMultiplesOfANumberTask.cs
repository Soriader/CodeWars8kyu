using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class FindMultiplesOfANumberTask
    {
        public static List<int> FindMultiples(int integer, int limit)
        {
            List<int> result = new List<int>();

            for (int i = integer; i <= limit; i += integer)
            {
                result.Add(i);
            }

            return result;


        }
    }
}
//https://www.codewars.com/kata/58ca658cc0d6401f2700045f/train/csharp