using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class NameShufflerTask
    {
        public static string NameShuffler(string str)
        {
            string[] names = str.Split(' ');

            if(names.Length >= 2)
            {
                string firstName = names[0];
                string lastName = names[names.Length - 1];
                string swappedFullName = lastName + " " + firstName;
                return swappedFullName;
            }
            else
            {
                return str;
            }
        }
        
    }
}
//https://www.codewars.com/kata/559ac78160f0be07c200005a/train/csharp