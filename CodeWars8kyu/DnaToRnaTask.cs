using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class DnaToRnaTask
    {
        public static string DnaToRna(string dna)
        {
            char[] charArray = dna.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == 'T')
                {
                    charArray[i] = 'U';
                }

            }

            string complement = new string(charArray);
            return complement;

            //https://www.codewars.com/kata/5556282156230d0e5e000089/train/csharp
        }
    }
}
