using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class ExampleTwistTask
    {

        public static string[] Websites = new string[1000];

        static ExampleTwistTask()
        {
            for (int i = 0; i < Websites.Length; i++)
            {
                Websites[i] = "codewars";
            }
        }

    }
}
//https://www.codewars.com/kata/525c1a07bb6dda6944000031/train/csharp