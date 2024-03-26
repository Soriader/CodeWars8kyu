using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class TerminalGameMoveFunctionTask
    {
        public static int Move(int position, int roll)
        {
            return position + 2* roll;  
        }
    }
}
