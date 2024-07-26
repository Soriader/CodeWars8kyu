using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
	public class EnumerableMagicTrueTask
	{
		public static bool Any(int[] arr, Func<int, bool> fun)
		{
			foreach (int item in arr)
			{
				if (fun(item))
				{
					return true;
				}
			}
			return false;
		}
	}
}
//https://www.codewars.com/kata/54598e89cbae2ac001001135/train/csharp