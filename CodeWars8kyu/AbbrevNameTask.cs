using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class AbbrevNameTask
    {
        public static string AbbrevName(string name)
        {
            string initials;
            string[] nameParts = name.Split(' ');

            if (nameParts.Length < 2)
            {
                throw new ArgumentException("Nazwa nie zawiera dwóch części oddzielonych spacją.");
            }

            return initials = $"{char.ToUpper(nameParts[0][0])}.{char.ToUpper(nameParts[1][0])}";

        }
    }
}
//https://www.codewars.com/kata/57eadb7ecd143f4c9c0000a3/train/csharp