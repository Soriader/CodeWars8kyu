using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class Hero
    {
        public string Name { get; set; }
        public float Health { get; set; } = 100;
        public float Damage { get; set; } = 5;
        public int Experience { get; set; } = 0;
        public string Position { get; set; } = "00";

        public Hero(string name = "Hero")
        {
            this.Name = name;
        }
    }
}
//https://www.codewars.com/kata/55e8aba23d399a59500000ce/train/csharp