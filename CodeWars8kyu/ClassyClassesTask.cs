using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            name = Name;    
            age = Age;
        }

        public static string Create(string name, int age)
        {
            return $"{name}s age is {age}";
        }
    }
}
