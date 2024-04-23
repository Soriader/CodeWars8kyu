using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class TheIfFunctionTask
    {
        public static void If(bool condition, Action func1, Action func2)
        {
            if (condition)
            {
                func1.Invoke();
            }
            else
            {
                func2.Invoke();
            }

        }
    }
}
//https://www.codewars.com/kata/54147087d5c2ebe4f1000805/train/csharp