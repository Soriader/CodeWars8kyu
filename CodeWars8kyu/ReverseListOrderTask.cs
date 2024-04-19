using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class ReverseListOrderTask
    {
        public static List<int> ReverseList(List<int> list)
        {
            if (list != null)
            {
                List<int> reversedList = new List<int>(list);
                reversedList.Reverse(); 
                return reversedList; 
            }

            return null;
        }
    }
}
//https://www.codewars.com/kata/53da6d8d112bd1a0dc00008b/train/csharp