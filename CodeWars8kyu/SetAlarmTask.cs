using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class SetAlarmTask
    {
        public static bool SetAlarm(bool employed, bool vacation)
        {
            if(employed == true && vacation == false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
