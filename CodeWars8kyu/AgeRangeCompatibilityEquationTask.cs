using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class AgeRangeCompatibilityEquationTask
    {
        public static string DatingRange(int age)
        {
            int min = 0;
            int max = 0;

            if(age <= 14)
            {
                min = (int)(age - 0.10 * age);
                max = (int)(age + 0.10 * age);

                return $"{min}-{max}";
            }

            min = age / 2 + 7;
            max = (age - 7) * 2;

            return $"{min}-{max}";

        }
    }
}
//https://www.codewars.com/kata/5803956ddb07c5c74200144e/train/csharp