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
            //List<string> result = new List<string>();

            string result = "";

            if(text == null || character == null)
            {
                return "";
            } 

            int iterator = 0;

            foreach (var item in text)
            {

                result += character;

            }

            return result;
        
        }
    }
}
