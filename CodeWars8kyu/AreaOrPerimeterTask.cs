using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class AreaOrPerimeterTask
    {
        public static int AreaOrPerimeter(int l, int w)
        {

            if (l == w)
            {
                var x = l * w
                    ; return x;
            }
            else
            {
                var y = 2 * l + 2 * w;
                return y;
            }
            //https://www.codewars.com/kata/5ab6538b379d20ad880000ab/train/csharp
        }
    }
}
