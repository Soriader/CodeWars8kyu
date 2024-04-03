using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class HelloNameOrWorldTask
    {
        public static string Hello(string name)
        {
            if (name == null || name == "")
            {
                return "Hello, World!";
            }

            name = char.ToUpper(name[0]) + name.Substring(1).ToLower();

            return $"Hello, {name}!";
        }
    }
}
//https://www.codewars.com/kata/57e3f79c9cb119374600046b/train/csharp