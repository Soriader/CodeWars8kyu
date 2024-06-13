using CodeWars8kyu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class DidSheSayHalloTask
    {
        public static bool Validate_hello(string greetings)
        {
            if (greetings.ToLower().Contains("czesc") || greetings.ToLower().Contains("ahoj") || greetings.ToLower().Contains("hello") || greetings.ToLower().Contains("ciao") || greetings.ToLower().Contains("salut")  || greetings.ToLower().Contains("hallo") || greetings.ToLower().Contains("hola")) return true;
            return false;
        }
    }
}
//https://www.codewars.com/kata/56a4addbfd4a55694100001f/train/csharp