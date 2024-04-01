using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CodeWars8kyu
{
    public class AddLengthTask
    {
        public static string[] AddLength(string str)
        {
            string[] words = str.Split(' ');
            List<string> result = new List<string>();

            foreach (string word in words)
            {
                int length = word.Length;
                result.Add($"{word} {length}");
            }

            return result.ToArray();

        }
    }
}
//https://www.codewars.com/kata/559d2284b5bb6799e9000047/train/csharp