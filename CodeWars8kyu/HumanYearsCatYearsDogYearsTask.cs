using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class HumanYearsCatYearsDogYearsTask
    {
        public static int[] HumanYearsCatYearsDogYears(int humanYears)
        {
            int catYears;
            int dogYears;

            switch (humanYears)
            {
                case 1:
                    {
                        catYears = 15;
                        dogYears = 15;
                        break;
                    }
                case 2:
                    {
                        catYears = 24;
                        dogYears = 24;
                        break;
                    }
                case >= 3:
                    {
                        catYears = 24 + ((humanYears - 2) * 4);
                        dogYears = 24 + ((humanYears - 2) * 5);
                        break;
                    }
                default:
                    {
                        catYears = 0;
                        dogYears = 0;
                        break;
                    }
            }

            return new int[] { humanYears, catYears, dogYears };

            //https://www.codewars.com/kata/5a6663e9fd56cb5ab800008b/train/csharp
        }
    }
}
