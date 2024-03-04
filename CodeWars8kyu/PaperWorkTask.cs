using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class PaperWorkTask
    {
        public static int PaperWork(int n, int m)
        {
            int count = n * m;

            if (n < 0 || m < 0)
            {
                count = 0;
            }

            return count;
        }
    }
}
//https://www.codewars.com/kata/55f9b48403f6b87a7c0000bd/train/csharp