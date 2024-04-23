using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class TakeTheFirstNElementsTask
    {
        public static int[] Take(int[] arr, int n)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if(i < n)
                {
                    result.Add(arr[i]);

                    if(i == n)
                    {
                        result.Add(arr[i]);
                    }
                }
            }

            return result.ToArray();
        }
    }
}
//https://www.codewars.com/kata/545afd0761aa4c3055001386/train/csharp