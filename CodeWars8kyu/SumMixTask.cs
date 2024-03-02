using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class SumMixTask
    {
        public static int SumMix(object[] x)
        {
            int sum = 0;
            int intValue;

            foreach (object o in x)
            {
                if (o is int)
                {
                    sum += (int)o;
                }
                else if (o is string)
                {
                    if (int.TryParse((string)o, out intValue))
                    {
                        sum += intValue;
                    }
                }

            }
            return sum;

            //https://www.codewars.com/kata/57eaeb9578748ff92a000009/train/csharp
        }
    }
}
