using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class YouOnlyNeedOneTask
    {
        public static bool Check(object[] a, object x)
        {

            if (a == null || x == null)
            {
                return false;
            }

            foreach (object item in a)
            {
                if (item.Equals(x))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
