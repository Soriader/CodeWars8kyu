using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
	public class TakeAnArrowToTheKneeTask
	{
		public static string ArrowFunc(int[] arr)
		{
			string result = "";

			for (int i = 0; i < arr.Length; i++)
			{
				result += (char)arr[i];
			}

			return result;
		}
	}
}
//https://www.codewars.com/kata/559f3123e66a7204f000009f/train/csharp