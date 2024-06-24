using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class SharkPontoonTask
    {
        public static string Shark( int pontoonDistance,int sharkDistance, int youSpeed,int sharkSpeed, bool dolphin)
        {
             
            if (dolphin)
            {
                sharkSpeed = sharkSpeed / 2;
            }

            double youTime = (double)pontoonDistance / youSpeed;
            double sharkTime = (double)sharkDistance / sharkSpeed;

            if (youTime <= sharkTime)
            {
                return "Alive!";
            }

            return "Shark Bait!";
        }
    }
}
//https://www.codewars.com/kata/57e921d8b36340f1fd000059/train/csharp

