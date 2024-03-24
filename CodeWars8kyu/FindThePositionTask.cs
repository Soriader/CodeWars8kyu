using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class FindThePositionTask
    {
        public static string Position(char alphabet)
        {
            if (char.IsLetter(alphabet))
            {
                alphabet = char.ToLower(alphabet); 
                int position = alphabet - 'a' + 1; 
                return "Position of alphabet: " + position;
            }
            else
            {
                return "";
            }
        }
    }
}
//https://www.codewars.com/kata/5808e2006b65bff35500008f/train/csharp