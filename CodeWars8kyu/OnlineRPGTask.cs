﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
	public class OnlineRPGTask
	{
		public static Object PlayerRankUp(int points)
		{
			if(points >= 100)
			{
				return "Well done! You have advanced to the qualifying stage. Win 2 out of your next 3 games to rank up.";
			}

			return false;
		}
	}
}
//https://www.codewars.com/kata/55849d76acd73f6cc4000087/train/csharp