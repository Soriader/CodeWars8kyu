using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
	public class CollinearityTask
	{
		public static bool Collinearity(int x1, int y1, int x2, int y2)
		{
			return x1 * y2 == y1 * x2;
		}
	}
}
//https://www.codewars.com/kata/65ba420888906c1f86e1e680/train/csharp
