using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class EnoughSpaceTask
    {
        public static int Enough(int cap, int on, int wait)
        {
            var result = cap - on;

            if (result > 0 && wait < result)
            {
                return 0;
            }
            else
            {
                return wait - result;
            }

        }
    }
}
//https://www.codewars.com/kata/5875b200d520904a04000003/train/csharp