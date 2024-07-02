using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class ConvertToBinaryTask
    {
        public static int ToBinary(int n)
        {
            return int.Parse(Convert.ToString(n, 2));

        }
    }
}
//https://www.codewars.com/kata/59fca81a5712f9fa4700159a/train/csharp
