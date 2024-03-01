using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public static class Kata
    {
        public static int[] humanYearsCatYearsDogYears(int humanYears)
        {
            int catYears;
            int dogYears;

            switch (humanYears)
            {
                case 1:
                    {
                        catYears = 15;
                        dogYears = 15;
                        break;
                    }
                case 2:
                    {
                        catYears = 24;
                        dogYears = 24;
                        break;
                    }
                case >= 3:
                    {
                        catYears = 24 + ((humanYears - 2) * 4);
                        dogYears = 24 + ((humanYears - 2) * 5);
                        break;
                    }
                default:
                    {
                        catYears = 0;
                        dogYears = 0;
                        break;
                    }
            }

            return new int[] { humanYears, catYears, dogYears };

            //https://www.codewars.com/kata/5a6663e9fd56cb5ab800008b/train/csharp
        }

        public static int OtherAngle(int a, int b)
        {
            int c = 180 - a - b;
            return c;
            //https://www.codewars.com/kata/5a023c426975981341000014/train/csharp
        }
        public static string Correct(string text)
        {
            text = text.Replace('5', 'S');

            text = text.Replace('0', 'O');

            text = text.Replace('1', 'I');

            return text;
            //https://www.codewars.com/kata/577bd026df78c19bca0002c0/train/csharp
        }
        public static string boolToWord(bool word)
        {
            string result = "";
            switch (word)
            {
                case true:
                    result = "Yes";
                    break;
                case false:
                    result = "No";
                    break;
            }
            return result;
            //https://www.codewars.com/kata/53369039d7ab3ac506000467/train/csharp
        }
        public static object[] RemoveEveryOther(object[] arr)
        {
            int newSize = (arr.Length + 1) / 2;  
            object[] newArray = new object[newSize]; 

            int newIndex = 0; 

            for (int i = 0; i < arr.Length; i += 2)
            {
                newArray[newIndex] = arr[i];
                newIndex++;
            }

            return newArray;


            //https://www.codewars.com/kata/5769b3802ae6f8e4890009d2/train/csharp
        }
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
