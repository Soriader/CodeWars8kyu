using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class HowOldWillIBeInTask
    {
        public static string CalculateAge(int birth, int yearTo)
        {

            if (birth == yearTo) return "You were born this very year!";

            if(birth - yearTo == 1)
            {
                return "You will be born in 1 year.";
            }

            if(yearTo - birth == 1)
            {
                return "You are 1 year old.";
            }

            if (birth > yearTo)
            {
                return $"You will be born in {birth - yearTo} years.";
            }
            else
            {
                return $"You are {yearTo - birth} years old.";
            }



        }
    }
}
//https://www.codewars.com/kata/5761a717780f8950ce001473/train/csharp