using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class CheckForFactorTask
    {
        public static bool CheckForFactor(int num, int factor)
        {
            if (factor <= 0)
            {
                return false; 
            }
            if (num % factor == 0)
            {
                return true;
            }
            else
            {
                return false; 
            }
        }
    }
}
//https://www.codewars.com/kata/55cbc3586671f6aa070000fb/train/csharp