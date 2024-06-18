using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class RemoveDuplicatesTask
    {
        public static int[] Distinct(int[] a)
        {
            return a.Distinct().ToArray();
        }
    }
}
//https://www.codewars.com/kata/57a5b0dfcf1fa526bb000118/train/csharp