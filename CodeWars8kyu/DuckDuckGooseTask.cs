using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
	public class DuckDuckGooseTask
	{
		public string Name { get; set; }

		public DuckDuckGooseTask(string name)
		{
			this.Name = name;
		}

		public static string DuckDuckGoose(DuckDuckGooseTask[] players, int goose)
		{
			int index = (goose - 1) % players.Length;
			return players[index].Name;
		}
	}
}
//https://www.codewars.com/kata/582e0e592029ea10530009ce/train/csharp