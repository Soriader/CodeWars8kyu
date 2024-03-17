using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class InvertValuesTask
    {
        public static int[] InvertValues(int[] input)
        {
            return input.Select(x => -x).ToArray();
        }
    }
}
//https://www.codewars.com/kata/5899dc03bc95b1bf1b0000ad/train/csharp