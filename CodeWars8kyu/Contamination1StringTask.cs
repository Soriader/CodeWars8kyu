using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class Contamination1StringTask
    {
        public static string Contamination(string text, string character)
        {
            string result = "";

            if(text == null || character == null)
            {
                return "";
            } 

            foreach (var item in text)
            {
                result += character;
            }

            return result;
        
        }
    }
}
//https://www.codewars.com/kata/596fba44963025c878000039/train/csharp