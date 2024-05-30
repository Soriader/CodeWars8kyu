using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class MergeTwoSortedArraysIntoOneTask
    {
        public static int[] MergeArrays(int[] arr1, int[] arr2)
        {
            List<int> result = new List<int>(arr1);
            result.AddRange(arr2);
            return result.Distinct().OrderBy(x => x).ToArray();
        }
    }
}
//https://www.codewars.com/kata/5899642f6e1b25935d000161/train/csharp