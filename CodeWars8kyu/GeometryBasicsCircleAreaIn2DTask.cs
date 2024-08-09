using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
	public class GeometryBasicsCircleAreaIn2DTask
	{
		public static double CircleArea(Circle circle)
		{
			return Math.Pow(circle.Radius, 2) * Math.PI;
		}
	}

	public class PointOfCircle
	{
		public double X { get; private set; }
		public double Y { get; private set; }

		public PointOfCircle(double x, double y)
		{
			this.X = x;
			this.Y = y;
		}
	}

	public class Circle
	{
		public PointOfCircle Center { get; private set; }
		public double Radius { get; private set; }

		public Circle(PointOfCircle center, double radius)
		{
			this.Center = center;
			this.Radius = radius;
		}
	}
}
//https://www.codewars.com/kata/58e3f824a33b52c1dc0001c0/train/csharp