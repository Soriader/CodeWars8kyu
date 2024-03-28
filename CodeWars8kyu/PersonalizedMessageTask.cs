using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class PersonalizedMessageTask
    {
        public static string Greet(string name, string owner)
        {
            if(name == owner)
            {
                return "Hello boss";
            }
            return "Hello guest";
        }
    }
}
//https://www.codewars.com/kata/5772da22b89313a4d50012f7/train/csharp