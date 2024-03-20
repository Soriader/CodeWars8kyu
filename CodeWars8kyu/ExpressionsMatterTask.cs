using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class ExpressionsMatterTask
    {
        public static int ExpressionsMatter(int a, int b, int c)
        {
            List<int> list = new List<int>();

            int combination1 = a * (b + c);
            int combination2 = a * b * c;
            int combination3 = a + b * c;
            int combination4 = (a + b) * c;
            int combination5 = a + b + c;
            int combination6 = a * b + c;
            int combination7 = a + b * c;
            int combination8 = a * (b * c);
            int combination9 = (a * b) * c;

            list.Add(combination1);
            list.Add(combination2);
            list.Add(combination3);
            list.Add(combination4);
            list.Add(combination5);
            list.Add(combination6);
            list.Add(combination7);
            list.Add(combination8);
            list.Add(combination9);


            return list.Max(x => x);

        }
    }
}
//https://www.codewars.com/kata/5ae62fcf252e66d44d00008e/train/csharp