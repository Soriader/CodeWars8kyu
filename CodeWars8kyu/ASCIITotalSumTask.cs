using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class ASCIITotalSumTask
    {
        public static int UniTotal(string str)
        {

            return str.Select(c => (int)c).Sum();

        }

    }
}
//https://www.codewars.com/kata/572b6b2772a38bc1e700007a/train/csharp