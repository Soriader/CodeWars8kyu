using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodeWars8kyu
{
    public class LogicalCalculatorTask
    {
        public static bool LogicalCalc(bool[] array, string op)
        {

            switch (op)
            {
                case "AND":
                    {
                        for (int i = 0; i < array.Length; i++)
                        {
                            if (array[i] == false)
                            {
                                return false;
                            }
                        }
                        return true;
                    }
                case "OR":
                    {
                        for (int i = 0; i < array.Length; i++)
                        {
                            if (array[i] == true)
                            {
                                return true;
                            }
                        }
                        return false;
                    }
                case "XOR":
                    {
                        var numberOfTrue = 0;
                        var numberOfFalse = 0;

                        for (int i = 0; i < array.Length; i++)
                        {
                            if (array[i] == true)
                            {
                                numberOfTrue++;
                            }
                            else
                            {
                                numberOfFalse++;
                            }

                        }
                        if (numberOfTrue == numberOfFalse)
                        {
                            return false;
                        }

                        if(numberOfTrue % 2 == 0)
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }

                    }
            }

            return false;
        }
    }
}
//https://www.codewars.com/kata/57096af70dad013aa200007b/train/csharp