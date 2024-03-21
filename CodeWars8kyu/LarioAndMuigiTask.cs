using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class LarioAndMuigiTask
    {
        public static List<int> PipeFix(List<int> numbers)
        {
            int startIndex = numbers.Min();
            int endIndex = numbers.Max();
            List<int> result = new List<int>();

            for (int i = startIndex; i <= endIndex; i++)
            {
                result.Add(i);
            }

            return result;

        }
    }
}
//https://www.codewars.com/kata/56b29582461215098d00000f/train/csharp