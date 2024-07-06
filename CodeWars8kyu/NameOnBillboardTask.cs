using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class NameOnBillboardTask
    {
        public static double Billboard(string name, double price = 30)
        {
            double result = 0;
            var check = name.ToCharArray();

            foreach (char c in check)
            {
                result += price;
            }

            return result;
        }
    }
}
//https://www.codewars.com/kata/570e8ec4127ad143660001fd/train/csharp