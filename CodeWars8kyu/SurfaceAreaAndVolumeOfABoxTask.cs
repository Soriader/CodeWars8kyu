using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
	public class SurfaceAreaAndVolumeOfABoxTask
	{
		public static int[] Get_size(int w, int h, int d)
		{
			return new int[] { (2 * w * h + 2 * h * d + 2 * d * w), (w * h * d) };
		}
	}
}
//https://www.codewars.com/kata/565f5825379664a26b00007c/train/csharp