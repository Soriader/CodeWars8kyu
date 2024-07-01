using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class CascadingSubsetsTask
    {
        public static IEnumerable<IEnumerable<int>> EachCons(int[] list, int n)
        {
            var result = new List<List<int>>();

            for (int i = 0; i <= list.Length - n; i++)
            {
                var subset = new List<int>();
                for (int j = 0; j < n; j++)
                {
                    subset.Add(list[i + j]);
                }
                result.Add(subset);
            }

            return result;
        }
    }
}
//https://www.codewars.com/kata/545af3d185166a3dec001190/train/csharp