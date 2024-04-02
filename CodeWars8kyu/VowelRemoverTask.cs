using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CodeWars8kyu
{
    public class VowelRemoverTask
    {
        public static string Shortcut(string input)
        {
            string vowels = "aeiou";
            string textWithoutVowels = new string(input.Where(c => !vowels.Contains(c)).ToArray());
            return textWithoutVowels;

        }
    }
}
//https://www.codewars.com/kata/5547929140907378f9000039/train/csharp