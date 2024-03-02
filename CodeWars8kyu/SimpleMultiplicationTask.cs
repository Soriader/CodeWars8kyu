using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class SimpleMultiplicationTask
    {
        public static int SimpleMultiplication(int x)
        {
            if (x % 2 != 0)
            {
                return x * 9;
            }
            else
            {
                return x * 8;
            }

            //https://www.codewars.com/kata/583710ccaa6717322c000105/train/csharp
        }
    }
}
