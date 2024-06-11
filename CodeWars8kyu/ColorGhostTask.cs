using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class ColorGhostTask
    {
        private readonly string[] Colors = { "white", "yellow", "purple", "red" };
        public string GetColor() { return Colors[new Random().Next(0, 4)]; }
    }
}
//https://www.codewars.com/kata/53f1015fa9fe02cbda00111a/train/csharp