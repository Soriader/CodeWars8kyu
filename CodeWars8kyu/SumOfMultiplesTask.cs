using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
	public class SumOfMultiplesTask
	{
		public static int SumMul(int n, int m) //2 i 9
		{
			if (n <= 0 || m <= 0 || n >= m)
			{
				throw new ArgumentException("Invalid input parameters.");
			}

			int result = 0;
			int multiple = n;

			while (multiple < m)
			{
				result += multiple;
				multiple += n;
			}

			return result;
		}

	}
}
//https://www.codewars.com/kata/57241e0f440cd279b5000829/train/csharp