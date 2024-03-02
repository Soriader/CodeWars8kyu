using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class RemoveEveryOtherTask
    {
        public static object[] RemoveEveryOther(object[] arr)
        {
            int newSize = (arr.Length + 1) / 2;
            object[] newArray = new object[newSize];

            int newIndex = 0;

            for (int i = 0; i < arr.Length; i += 2)
            {
                newArray[newIndex] = arr[i];
                newIndex++;
            }

            return newArray;


            //https://www.codewars.com/kata/5769b3802ae6f8e4890009d2/train/csharp
        }
    }
}
