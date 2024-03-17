using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CodeWars8kyu
{
    public class HowMuchILoveYouTask
    {
        public static string HowMuchILoveYou(int nb_petals)
        {
            string[] phrases = { "I love you", "a little", "a lot", "passionately", "madly", "not at all" };
            int lastPetalIndex = (nb_petals - 1) % phrases.Length;

            return phrases[lastPetalIndex];
        }
    }
}
//https://www.codewars.com/kata/57f24e6a18e9fad8eb000296/train/csharp
