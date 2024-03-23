using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class IsHeGonnaSurviveTask
    {
        public static bool Hero(int bullets, int dragons)
        {
            return bullets >= dragons * 2;
        }
    }
}
//https://www.codewars.com/kata/59ca8246d751df55cc00014c/train/csharp