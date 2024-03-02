using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class RepeatStrTask
    {
        public static string RepeatStr(int n, string s)
        {
            string text = "";

            for (int i = 0; i < n; i++)
            {

                text += s;

            }

            return text;

            //https://www.codewars.com/kata/57a0e5c372292dd76d000d7e/train/csharp
        }
    }
}
