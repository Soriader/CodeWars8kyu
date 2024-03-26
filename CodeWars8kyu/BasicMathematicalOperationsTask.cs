using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class BasicMathematicalOperationsTask
    {
        public static double basicOp(char operation, double value1, double value2)
        {
            switch(operation)
            {
                case '+':
                    {
                        return value1 + value2;
                    }
                case '-':
                    {
                        return value1 - value2;
                    }
                case '*':
                    {
                        return value1 * value2;
                    }
                case '/':
                    {
                        return value1 / value2;
                    }
                    default:
                    {
                        return 0;
                    }
            }
        }
    }
}
//https://www.codewars.com/kata/57356c55867b9b7a60000bd7/train/csharp
