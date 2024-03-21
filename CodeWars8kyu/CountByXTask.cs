using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class CountByXTask
    {
        public static int[] CountBy(int x, int n)
        {
            int[] z = new int[n];
            int multiple = x;

            for (int i = 0; i < n; i++)
            {
                z[i] = multiple;
                multiple += x;
            }

            return z;
        }
    }
}
