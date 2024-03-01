using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public static class Kata
    {

        public static string Smash(string[] words)
        {
            return string.Join(" ", words);
            //https://www.codewars.com/kata/53dc23c68a0c93699800041d/train/csharp
        }

        public static string HelloWord()
        {
            return "hello world!";
            //https://www.codewars.com/kata/523b4ff7adca849afe000035/train/csharp
        }

        public static int Multiply(int a, int b)
        {
            return a*b;
            //https://www.codewars.com/kata/50654ddff44f800200000004/train/csharp
        }

        public static int MakeNegative(int number)
        {
            if (number == 0)
            {
                Console.WriteLine("Invalid answer!");
                return 0;
            }

            if (number < 0)
            {
                Console.WriteLine(number);
                return number;
            }
            else
            {
                var x = -number;
                Console.WriteLine(x);
                return x;
            }

            //https://www.codewars.com/kata/55685cd7ad70877c23000102/train/csharp
        }
    }
}
