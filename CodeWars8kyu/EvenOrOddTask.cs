using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class EvenOrOddTask
    {
        public static string EvenOrOdd(int number)
        {

            if (number % 2 == 0)
            {
                return "Even";
            }
            else
            {
                return "Odd";
            }

        }
    }
}
//https://www.codewars.com/kata/53da3dbb4a5168369a0000fe/train/csharp