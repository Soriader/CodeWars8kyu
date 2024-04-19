using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodeWars8kyu
{
    public class IfElseAndTernaryOperatorTask
    {
        public static int SaleHotDogs(int n)
        {
            int result = 0;

            if (n < 5)
            {
                result = n * 100;
            }
            else if(n >= 5 && n< 10)
            {
                result = n * 95;
            }
            if(n >= 10)
            {
                result = n * 90;
            }

            return result;
        }
    }
}
//https://www.codewars.com/kata/57202aefe8d6c514300001fd/train/csharp