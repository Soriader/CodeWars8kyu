using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class TrafficLightTask
    {
        public static string UpdateLight(string current)
        {
            switch(current.ToLower())
            {
                case "green":
                    {
                        return "yellow";
                    }
                case "yellow":
                    {
                        return "red";
                    }
                case "red":
                    {
                        return "green";
                    }
            }

            return "";
        
        }
    }
}
//https://www.codewars.com/kata/58649884a1659ed6cb000072/train/csharp