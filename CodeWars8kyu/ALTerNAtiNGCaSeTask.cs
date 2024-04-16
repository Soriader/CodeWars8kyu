using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class ALTerNAtiNGCaSeTask
    {
        public static string ToAlternatingCase(string s)
        {
            var word = s.ToCharArray();
            string result = "";

            for (int i = 0; i < word.Length; i++)
            {

                if (char.IsUpper(word[i]))
                {
                    result += word[i].ToString().ToLower();
                        
                }
                else
                {
                    result += word[i].ToString().ToUpper();
                }
            }

            return result;
        }
    }
}
//https://www.codewars.com/kata/56efc695740d30f963000557/train/csharp