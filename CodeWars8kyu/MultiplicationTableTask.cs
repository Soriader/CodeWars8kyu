using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class MultiplicationTableTask
    {
        public static string MultiTable(int number)
        {
            string table = "";

            for (int i = 1; i <= 10; i++)
            {
                int result = i * number;
                table += $"{i} * {number} = {result}";

                if (i != 10)
                {
                    table += "\n";
                }
            }

            return table;
        }
    }
}
//https://www.codewars.com/kata/5a2fd38b55519ed98f0000ce/train/csharp