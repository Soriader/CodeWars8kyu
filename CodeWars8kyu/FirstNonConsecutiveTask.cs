using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class FirstNonConsecutiveTask
    {
        public static object FirstNonConsecutive(int[] arr)
        {

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i + 1] != arr[i] + 1)
                {
                    return arr[i + 1];
                }
            }

            return null;
        }
    }
}
//https://www.codewars.com/kata/58f8a3a27a5c28d92e000144/train/csharp