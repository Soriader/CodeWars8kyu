using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class SumWithoutHighestAndLowestNumberTask
    {
        public static int Sum(int[] numbers)
        {

            if (numbers == null || numbers.Length <= 1 || numbers.All(x => x == numbers[0]))
            {
                return 0;
            }

            int sum = numbers.Sum() - numbers.Max() - numbers.Min();

            return sum;
        }
    }
}
//https://www.codewars.com/kata/576b93db1129fcf2200001e6/train/csharp