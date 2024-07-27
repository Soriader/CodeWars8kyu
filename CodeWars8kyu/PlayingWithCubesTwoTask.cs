using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
	public class PlayingWithCubesTwoTask
	{
		private int side;

		public PlayingWithCubesTwoTask()
		{
			this.side = 0;
		}

		public PlayingWithCubesTwoTask(int side)
		{
			this.Side = side;
		}

		public int GetSide()
		{
			return this.side;
		}

		public void SetSide(int side)
		{
			this.side = Math.Abs(side);
		}

		public int Side
		{
			get { return this.side; }
			set { this.side = Math.Abs(value); }
		}
	}
}
//https://www.codewars.com/kata/55c0ac142326fdf18d0000af/train/csharp