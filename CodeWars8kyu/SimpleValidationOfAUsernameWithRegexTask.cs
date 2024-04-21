using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class SimpleValidationOfAUsernameWithRegexTask
    {
        public static bool ValidateUsr(string username)
        {
            if(username == null) return false;

            if (username.Length >= 4 && username.Length <= 16)
            {
                foreach (char c in username)
                {
                    if (!(char.IsLower(c) || char.IsDigit(c) || c == '_'))
                    {
                        return false;
                    }
                }
                return true;
            }

            return false;
        }

        
    }
}
//https://www.codewars.com/kata/56a3f08aa9a6cc9b75000023/train/csharp