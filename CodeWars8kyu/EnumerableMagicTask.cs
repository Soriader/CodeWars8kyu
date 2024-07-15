using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class EnumerableMagicTask
    {
        public static bool All(int[] arr, Func<int, bool> fun)
        {
            foreach (var item in arr)
            {
                if (!fun(item))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
//https://www.codewars.com/kata/54598d1fcbae2ae05200112c/train/csharp