using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class BoolToWordTask
    {
        public static string BoolToWord(bool word)
        {
            string result = "";
            switch (word)
            {
                case true:
                    result = "Yes";
                    break;
                case false:
                    result = "No";
                    break;
            }
            return result;
            //https://www.codewars.com/kata/53369039d7ab3ac506000467/train/csharp
        }
    }
}
