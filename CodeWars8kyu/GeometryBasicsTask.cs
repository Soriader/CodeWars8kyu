using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class GeometryBasicsTask
    {
        public static double DistanceBetweenPoints(Point a, Point b)
        {
            double deltaX = a.X - b.X;
            double deltaY = a.Y - b.Y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
    }
}
//https://www.codewars.com/kata/58dced7b702b805b200000be/train/csharp