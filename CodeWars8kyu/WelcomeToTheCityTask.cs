using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class WelcomeToTheCityTask
    {
        public static string SayHello(string[] name, string city, string state)
        {
            string nameOfNewCitizen = "";
            foreach (string str in name)
            {
                nameOfNewCitizen += str + " ";

            }

            nameOfNewCitizen = nameOfNewCitizen.TrimEnd();

            return $"Hello, {nameOfNewCitizen}! Welcome to {city}, {state}!";
        }
    }
}
//https://www.codewars.com/kata/5302d846be2a9189af0001e4/train/csharp