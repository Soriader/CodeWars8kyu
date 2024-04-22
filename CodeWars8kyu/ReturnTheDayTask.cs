using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class ReturnTheDayTask
    {
        public static string WhatDay(int n)
        {
            switch(n)
            {
                case 1:
                    {
                        return "Sunday";
                    }
                case 2:
                    {
                        return "Monday";
                    }
                case 3:
                    {
                        return "Tuesday";
                    }
                case 4:
                    {
                        return "Wednesday";
                    }
                case 5:
                    {
                        return "Thursday";
                    }
                case 6:
                    {
                        return "Friday";
                    }
                case 7:
                    {
                        return "Saturday";
                    }
                default:
                {
                    return "Wrong, please enter a number between 1 and 7";
                }
            }

        }
    }
}
//https://www.codewars.com/kata/59dd3ccdded72fc78b000b25/train/csharp