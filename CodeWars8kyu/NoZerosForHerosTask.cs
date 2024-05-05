using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class NoZerosForHerosTask
    {
        public static int NoBoringZeros(int n)
        {
            string result = n.ToString().TrimEnd('0');

            if (result == "")
            {
                return 0;
            }
            else
            {
                return int.Parse(result);
            }

        }
    }
}
//https://www.codewars.com/kata/570a6a46455d08ff8d001002/train/csharp