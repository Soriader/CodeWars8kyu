using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class TipCalculatorTask
    {
        public static int CalculateTip(double amount, string rating)
        {

            switch(rating.ToLower())
            {
                case "terrible":
                    {
                        return 0;
                    }
                case "poor":
                    {
                        amount = amount * 0.05;
                        return (int)Math.Ceiling(amount);
                    }
                case "good":
                    {
                        amount = amount * 0.1;
                        return (int)Math.Ceiling(amount);
                    }
                case "great":
                    { 
                        amount = amount * 0.15;
                        return (int)Math.Ceiling(amount);
                    }
                case "excellent":
                    {
                        amount = amount * 0.2;
                        return (int)Math.Ceiling(amount);
                    }
                default:
                    {
                        return -1;
                    }
            }
        }
    }
}
//https://www.codewars.com/kata/56598d8076ee7a0759000087/train/csharp