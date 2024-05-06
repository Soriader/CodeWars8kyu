using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class SleighAuthenticationTask
    {
        public static bool Authenticate(string name, string password)
        {
            if(name == "Santa Claus" && password == "Ho Ho Ho!")
            {
                return true;
            }

            return false;
        }
    }
}
//https://www.codewars.com/kata/52adc142b2651f25a8000643/train/csharp