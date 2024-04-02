using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class WhatIsBetweenTask
    {
        public static int[] Between(int a, int b)
        {
            int[] result = new int[b - a + 1]; 

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = a + i; 
            }

            return result;
        }
    }
}
//https://www.codewars.com/kata/55ecd718f46fba02e5000029/train/csharp