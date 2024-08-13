using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
	public class AddNewItemTask
	{
		public static List<int> AddExtra(List<int> listOfNumbers)
		{
			List<int> list = new List<int>(listOfNumbers);

			int test = 1;

			list.Add(test);

			return list;
		}
	}
}
//https://www.codewars.com/kata/566dc05f855b36a031000048/train/csharp