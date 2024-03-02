using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class CorrectTask
    {
        public static string Correct(string text)
        {
            text = text.Replace('5', 'S');

            text = text.Replace('0', 'O');

            text = text.Replace('1', 'I');

            return text;
            //https://www.codewars.com/kata/577bd026df78c19bca0002c0/train/csharp
        }
    }
}
