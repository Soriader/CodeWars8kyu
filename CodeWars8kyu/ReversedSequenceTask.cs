using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class ReversedSequenceTask
    {
        public static int[] ReverseSeq(int n)
        {
            int[] seq = new int[n];

            if(n > 0)
            {
                seq[0] = n;

                if (n > 0)
                {
                    for (int i = 0; i < n; i++)
                    {
                        seq[i] = n - i;
                    }
                }
            }

            return seq;
        }
    }
}
//https://www.codewars.com/kata/5a00e05cc374cb34d100000d/train/csharp