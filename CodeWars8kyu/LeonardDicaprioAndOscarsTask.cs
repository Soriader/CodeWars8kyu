using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class LeonardDicaprioAndOscarsTask
    {
        public static string Leo(int oscar)
        {
            if(oscar > 88)
            {
                return "Leo got one already!";
            }
            switch (oscar)
            {
                case 88:
                    {
                        return "Leo finally won the oscar! Leo is happy";

                    }
                case 86:
                    {
                        return "Not even for Wolf of wallstreet?!";
                    }
                    default:
                    {
                        return "When will you give Leo an Oscar?";
                    }
            }

        }
    }
}
//https://www.codewars.com/kata/56d49587df52101de70011e4/train/csharp