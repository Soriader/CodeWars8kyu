using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
	public class ExclamationMarksSeriesSixTask
	{
		public static string Remove(string s, int n)
		{
			for (int i = 0; i < n; i++)
			{
				int index = s.IndexOf('!'); 
				if (index == -1)
				{
					break;
				} 
				s = s.Remove(index, 1); 
			}
			return s;
		}
	}
}
//https://www.codewars.com/kata/57faf7275c991027af000679/train/csharp