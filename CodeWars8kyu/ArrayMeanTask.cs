using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class ArrayMeanTask
    {
        public static int FindAverage(int[] nums)
        {
            if(nums is null)
            {
                return 0;
            }

            int iterator = 0;

            foreach (var item in nums)
            {
                iterator++;
            }

            return nums.Aggregate((x, y) =>  x + y)/iterator;
        
        }
    }
}
