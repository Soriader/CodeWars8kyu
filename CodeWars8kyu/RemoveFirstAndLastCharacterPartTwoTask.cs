using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class RemoveFirstAndLastCharacterPartTwoTask
    {
        public static string Array(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return null;
            }

            string[] result = s.Split(',');

            if (result.Length < 3)
            {
                return null;
            }

            return string.Join(" ", result, 1, result.Length - 2);

        }
    }
}
//https://www.codewars.com/kata/570597e258b58f6edc00230d/train/csharp