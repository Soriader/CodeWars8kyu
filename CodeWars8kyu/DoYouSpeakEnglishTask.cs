using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class DoYouSpeakEnglishTask
    {
        public static bool SpeakEnglish(string sentence)
        {
            var result = sentence.ToLower();

            if (result.Contains("english"))
            {
                return true;
            }

            return false;
        }
    }
}
//https://www.codewars.com/kata/58dbdccee5ee8fa2f9000058/train/csharp