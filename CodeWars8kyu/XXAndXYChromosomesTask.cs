using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class XXAndXYChromosomesTask
    {
        public static string ChromosomeCheck(string sperm)
        {
            if(sperm == "XY")
            {
                return "Congratulations! You're going to have a son.";
            }

            return "Congratulations! You're going to have a daughter.";
        }
    }
}
//https://www.codewars.com/kata/56530b444e831334c0000020/train/csharp
