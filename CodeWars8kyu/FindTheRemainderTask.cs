using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class FindTheRemainderTask
    {
        public static int Remainder(int a, int b)
        {
            try
            {
                if (a > b)
                    return a % b;
                else
                    return b % a;
            }
            catch
            {
                throw new DivideByZeroException("Division by zero");
            }

        }
    }
}
//https://www.codewars.com/kata/524f5125ad9c12894e00003f/train/csharp