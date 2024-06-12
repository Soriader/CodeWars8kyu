using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class CheckSameCaseTask
    {
        public static int SameCase(char a, char b)
        {
            if(char.IsDigit(a) || char.IsDigit(b)) return -1;

            if(char.IsLetter(a) && char.IsLetter(b))
            {
                if(char.IsLower(a) && char.IsLower(b))
                {
                    return 1;
                }

                if(char.IsUpper(a) && char.IsUpper(b))
                {
                    return 1;
                }
                
                return 0;
            }

            return -1;
        }
    }
}
//https://www.codewars.com/kata/5dd462a573ee6d0014ce715b/train/csharp