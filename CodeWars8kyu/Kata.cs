using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public static class Kata
    {
        public static string Remove_char(string s)
        {
            if (s.Length > 2)
            {
                return s.Substring(1, s.Length - 2);
            }
            else
            {
                return "";
            }

            //https://www.codewars.com/kata/56bc28ad5bdaeb48760009b0/train/csharp
        }
        public static int AreaOrPerimeter(int l, int w)
        {

            if (l == w)
            {
                var x = l * w
                    ; return x;
            }
            else
            {
                var y = 2 * l + 2 * w;
                return y;
            }
            //https://www.codewars.com/kata/5ab6538b379d20ad880000ab/train/csharp
        }

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
