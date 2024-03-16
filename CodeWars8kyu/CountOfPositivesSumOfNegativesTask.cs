using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class CountOfPositivesSumOfNegativesTask
    {
        public static int[] CountPositivesSumNegatives(int[] input)
        {
            if (input == null || input.Length == 0)
            {
                return new int[0]; 
            }

            int[] result = { 0, 0 };

            foreach (int num in input)
            {
                if (num > 0)
                {
                    result[0]++; 
                }
                else if (num < 0)
                {
                    result[1] += num; 
                }
            }

            return result;
        }
    }
}
//https://www.codewars.com/kata/576bb71bbbcf0951d5000044/train/csharp