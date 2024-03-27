using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class AreYouPlayingBanjoTask
    {
        public static string AreYouPlayingBanjo(string name)
        {
            if(name.First().ToString().ToLower() == "r")
            {
                return name + " plays banjo";
            }

            return name + " does not play banjo";
        }
    }
}
//https://www.codewars.com/kata/53af2b8861023f1d88000832/train/csharp