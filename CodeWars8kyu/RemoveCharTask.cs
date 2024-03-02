using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class RemoveCharTask
    {
        public static string RemoveChar(string s)
        {
            if (s.Length > 2)
            {
                return s.Substring(1, s.Length - 2);
            }
            else
            {
                return "";
            }

            //https://www.codewars.com/kata/56bc28ad5bdaeb48760009b0/train/csharp
        }
    }
}
