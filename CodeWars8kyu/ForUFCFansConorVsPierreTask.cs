using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class ForUFCFansConorVsPierreTask
    {
        public static string Quote(string fighter)
        {
            if (fighter.ToLower() == "george saint pierre") return "I am not impressed by your performance.";

            return "I'd like to take this chance to apologize.. To absolutely NOBODY!";
        }
    }
}
//https://www.codewars.com/kata/582dafb611d576b745000b74/train/csharp