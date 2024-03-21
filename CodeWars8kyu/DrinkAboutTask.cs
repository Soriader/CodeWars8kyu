using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace CodeWars8kyu
{
    public class DrinkAboutTask
    {
        public static string PeopleWithAgeDrink(int old)
        {
            if(old <= 13)
            {
                return "drink toddy";
            }

            if (old >= 14 && old <= 17)
            {
                return "drink coke";
            }
            if (old > 17 && old <= 20)
            {
                return "drink beer";
            }
            else
            {
                return "drink whisky";
            }
        }

    }
}
//https://www.codewars.com/kata/56170e844da7c6f647000063/train/csharp
