using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class FuelCalculatorTotalCostTask
    {
        public static double FuelPrice(double litres, double pricePerLitre)
        {
            double discountPerLitre = Math.Min((int)(litres / 2) * 0.05, 0.25);
            double totalCost = litres * (pricePerLitre - discountPerLitre);
            return Math.Round(totalCost, 2);
        }
    }
}
//https://www.codewars.com/kata/57b58827d2a31c57720012e8/train/csharp