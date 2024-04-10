using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class PriceOfMangoesTask
    {
        public static int Mango(int quantity, int price)
        {

            int result = 0;

            if(quantity <=2) 
            { 
                return result = quantity*price;
            }
            else
            {
                return result = (quantity*price) - (quantity/3* price);
            }


        }
    }
}
//https://www.codewars.com/kata/57a77726bb9944d000000b06/train/csharp