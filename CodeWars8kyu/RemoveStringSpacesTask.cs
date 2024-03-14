using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class RemoveStringSpacesTask
    {
        public static string NoSpace(string input)
        {
            var spaceDestroyer = input.Replace(" ", "");
            return spaceDestroyer;
        }
    }
}
//https://www.codewars.com/kata/57eae20f5500ad98e50002c5/train/csharp