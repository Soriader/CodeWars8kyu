using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class StrCountAllStarCodeChallengeTask
    {
        public static int StrCount(string str, char letter)
        {
            var howManyLetter = str.Count(c => c == letter);
            return howManyLetter;
        }
    }
}
//https://www.codewars.com/kata/5865918c6b569962950002a1/train/csharp