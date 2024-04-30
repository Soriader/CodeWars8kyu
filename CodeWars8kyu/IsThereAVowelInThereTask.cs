using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodeWars8kyu
{
    public class IsThereAVowelInThereTask
    {
        public static object[] IsVow(object[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                switch (a[i])
                {
                    case 97:
                        {
                            a[i] = "a";
                            break;
                        }
                    case 101:
                        {
                            a[i] = "e";
                            break;
                        }
                    case 105:
                        {
                            a[i] = "i";
                            break;
                        }
                    case 111:
                        {
                            a[i] = "o";
                            break;
                        }
                    case 117:
                        {
                            a[i] = "u";
                            break;
                        }
                }

            }

            return a;

        }
    }
}
