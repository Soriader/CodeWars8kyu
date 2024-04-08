using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class ReversingWordsInAStringTask
    {
        public static string Reverse(string text)
        {
            var result = text.Split(' ');
            var reversed = String.Join(" ", result.Reverse());
            return reversed;

        }
    }
    
}
//https://www.codewars.com/kata/57a55c8b72292d057b000594/train/csharp