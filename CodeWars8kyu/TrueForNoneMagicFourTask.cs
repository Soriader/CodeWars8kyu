using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
	public class TrueForNoneMagicFourTask
	{
		public static bool None(int[] arr, Func<int, bool> fun)
		{
			foreach (var item in arr)
			{
				if (fun(item))
				{
					return false;
				}
			}
			return true;
		}
	}
}
//https://www.codewars.com/kata/545993ee52756d98ca0010e1/train/csharp