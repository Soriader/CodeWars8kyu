using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class PlayingWithCubesTask
    {
        private int Side;
        public int GetSide()
        {
            return Side;
        }

        public PlayingWithCubesTask()
        {
            Side = 0;
        }

        public void SetSide(int num)
        {
            Side = num;
        }
    }
}
//https://www.codewars.com/kata/55c0a79e20be94c91400014b/train/csharp