using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class OtherAngleTask
    {
        public static int OtherAngle(int a, int b)
        {
            int c = 180 - a - b;
            return c;
            //https://www.codewars.com/kata/5a023c426975981341000014/train/csharp
        }
    }
}
