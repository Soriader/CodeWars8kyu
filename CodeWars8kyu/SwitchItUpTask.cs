using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class SwitchItUpTask
    {
        public static string SwitchItUp(int number)
        {
            if(number >= 0 ||number <= 9)
            {
                switch(number)
                {
                    case 0:
                        {
                            return "Zero";
                        }
                    case 1:
                        {
                            return "One";
                        }
                    case 2:
                        {
                            return "Two";
                        }
                    case 3:
                        {
                            return "Three";
                        }
                    case 4:
                        {
                            return "Four";
                        }
                    case 5:
                        {
                            return "Five";
                        }
                    case 6:
                        {
                            return "Six";
                        }
                    case 7:
                        {
                            return "Seven";
                        }
                    case 8:
                        {
                            return "Eight";
                        }
                    case 9:
                        {
                            return "Nine";
                        }
                }
            }
            return "";
        }
    }
}
//https://www.codewars.com/kata/5808dcb8f0ed42ae34000031/train/csharp