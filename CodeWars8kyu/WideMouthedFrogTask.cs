using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class WideMouthedFrogTask
    {
        public static string MouthSize(string animal)
        {
            if(animal.ToLower() == "alligator")
            {
                return "small";
            }

            return "wide";

        }
    }
}
//https://www.codewars.com/kata/57ec8bd8f670e9a47a000f89/train/csharp