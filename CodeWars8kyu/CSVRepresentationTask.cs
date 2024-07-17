using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class CSVRepresentationTask
    {
        public static string ToCsvText(int[][] array)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    result.Append(array[i][j]);
                    if (j < array[i].Length - 1)
                    {
                        result.Append(",");
                    }
                }
                if (i < array.Length - 1)
                {
                    result.Append("\n");
                }
            }

            return result.ToString();
        }
    }
}
