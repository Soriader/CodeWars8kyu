using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class FakeBinaryTask
    {
        public static string FakeBin(string x)
        {
            char[] toChar = x.ToCharArray();

            for (int i = 0; i < toChar.Length; i++)
            {
                int number = int.Parse(toChar[i].ToString());

                if (number < 5)
                {
                    toChar[i] = '0';
                }
                else
                {
                    toChar[i] = '1';
                }
            }

            return new string(toChar);
        }
    }
}
//https://www.codewars.com/kata/57eae65a4321032ce000002d/train/csharp