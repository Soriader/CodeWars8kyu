using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class ConvertAStringToANumberTask
    {
        public static int StringToNumber(string str)
        {
            int result = 0;
            var number = int.TryParse(str, out result);
            return result;
        
        }
    }
}
//https://www.codewars.com/kata/544675c6f971f7399a000e79/train/csharp