using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class SimpleCalculatorTask
    {
        public static double Calculator(double a, double b, char op)
        {
            switch(op)
            {
                case '+':
                    {
                        return a + b;
                    }
                case '/':
                    {
                        return a / b;
                    }
                case '*':
                    {
                        return a * b;
                    }
                case '-':
                    {
                        return a - b;
                    }
                    default:
                    {
                        throw new ArgumentException("Invalid operation sign");
                    }
            }
        }
    }
}
//https://www.codewars.com/kata/5810085c533d69f4980001cf/train/csharp