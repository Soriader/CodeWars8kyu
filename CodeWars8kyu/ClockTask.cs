using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class ClockTask
    {
        public static int Past(int h, int m, int s)
        {
            return h * 3600000 + m * 60000 + s * 1000;
        }
    }
}
//https://www.codewars.com/kata/55f9bca8ecaa9eac7100004a/train/csharp
