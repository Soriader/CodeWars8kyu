using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class ReturnTwoHighestValuesInListTask
    {
        public static int[] TwoHighest(int[] arr)
        {
            if (arr.Length == 0) return Array.Empty<int>();

            var distinctSortedList = arr.Distinct().OrderByDescending(x => x).ToList();

            return distinctSortedList.Take(2).ToArray();

        }
    }
}
//https://www.codewars.com/kata/57ab3c09bb994429df000a4a/train/csharp