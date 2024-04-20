using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;

namespace CodeWars8kyu
{
    public class USDToCNYTask
    {
        public static string Usdcny(int usd)
        {
            double result = usd * 6.75;
            return $"{result:F2} Chinese Yuan";
        }
    }
}
//https://www.codewars.com/kata/5977618080ef220766000022/train/csharp