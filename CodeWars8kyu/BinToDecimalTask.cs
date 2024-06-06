using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class BinToDecimalTask
    {
        public static int BinToDec(string s)
        {
            var binary = s.ToCharArray();
            int decimalNumber = 0;
            int power = 0;

            for (int i = binary.Length - 1; i >= 0; i--)
            {
                if (binary[i] == '1')
                {
                    decimalNumber += (int)Math.Pow(2, power);
                }

                power++;
            }

            return decimalNumber;
        }
    }
}
//https://www.codewars.com/kata/57a5c31ce298a7e6b7000334/train/csharp
