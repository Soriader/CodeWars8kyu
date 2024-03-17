using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodeWars8kyu
{
    public class CalculateBMITask
    {
        public static string Bmi(double weight, double height)
        {
            var result = weight / Math.Pow(height, 2);

            if(result <= 18.5)
            {
                return "Underweight";
            }
            if(result <= 25.0)
            {
                return "Normal";
            }
            if(result <= 30.0)
            {
                return "Overweight";
            }

            return "Obese";
        }
    }
}
//https://www.codewars.com/kata/57a429e253ba3381850000fb/train/csharp