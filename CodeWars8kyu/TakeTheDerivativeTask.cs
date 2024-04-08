using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class TakeTheDerivativeTask
    {
        public static string Derive(double coefficient, double exponent)
        {
            var multiplication = coefficient * exponent;
            var newExponent = exponent - 1;
            return $"{multiplication}x^{newExponent}";
        }
    }
}
//https://www.codewars.com/kata/5963c18ecb97be020b0000a2/train/csharp