using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class HexToDecimalTask
    {
        public static int HexToDec(string hexString)
        {
            int result = 0;
            int sign = 1;

            if (hexString.StartsWith("-"))
            {
                sign = -1;
                hexString = hexString.Substring(1); 
            }

            for (int i = 0; i < hexString.Length; i++)
            {
                char hexChar = hexString[i];
                int digitValue;

                if (hexChar >= '0' && hexChar <= '9')
                {
                    digitValue = hexChar - '0'; 
                }
                else if (hexChar >= 'A' && hexChar <= 'F')
                {
                    digitValue = hexChar - 'A' + 10;
                }
                else if (hexChar >= 'a' && hexChar <= 'f')
                {
                    digitValue = hexChar - 'a' + 10; 
                }
                else
                {
                    throw new ArgumentException("Error: " + hexChar);
                }

                result = 16 * result + digitValue;
            }

            return result * sign; 
        }
    }
}
//https://www.codewars.com/kata/57a4d500e298a7952100035d/train/csharp