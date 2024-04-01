using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class PowersOfTwoTask
    {
        public static BigInteger[] PowersOfTwo(int n)
        {
            BigInteger[] powerTwo = new BigInteger[n + 1];

            for (int i = 0; i <= n; i++)
            {
                powerTwo[i] = BigInteger.Pow(2, i);
            }

            return powerTwo;

        }
    }
}
//https://www.codewars.com/kata/57a083a57cb1f31db7000028/train/csharp