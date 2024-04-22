using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class IncludeTask
    {
        public static bool Include(int[] arr, int item)
        {
            if(arr.Contains(item)) return true;
            return false;
        }
    }
}
//https://www.codewars.com/kata/545991b4cbae2a5fda000158/train/csharp