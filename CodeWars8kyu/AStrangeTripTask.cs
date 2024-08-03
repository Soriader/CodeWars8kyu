using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
	public class AStrangeTripTask
	{
		public static bool IsLockNessMonster(string sentence)
		{
			if (sentence.ToLower().Contains("tree fiddy") || sentence.Contains("3.50"))
			{
				return true;
			}

			return false;
		}

	}
}
//https://www.codewars.com/kata/55ccdf1512938ce3ac000056/train/csharp