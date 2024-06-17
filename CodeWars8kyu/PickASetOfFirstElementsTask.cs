using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class PickASetOfFirstElementsTask
    {
        public static object[] TakeFirstElements(object[] array, int n = 1)
        {
            if (n <= 0) return new object[] { };

            return array.Take(n).ToArray();
        }
    }
}
//https://www.codewars.com/kata/572b77262bedd351e9000076/train/csharp