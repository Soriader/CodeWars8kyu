using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class QuadrantsTask
    {
        public static int Quadrant(int x, int y)
        {

            return (x, y) switch
            {
                ( > 0, > 0) => 1, 
                ( < 0, > 0) => 2, 
                ( < 0, < 0) => 3, 
                ( > 0, < 0) => 4,

            };
        }
    }
}
//https://www.codewars.com/kata/643af0fa9fa6c406b47c5399/train/csharp