using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class LocalizeTheBarycenterTask
    {
        public static double[] BarTriang(double[] x, double[] y, double[] z)
        {
            List<double> result = new List<double>();
            double xZero = (x[0] + y[0] + z[0]) / 3;
            xZero = Math.Round(xZero, 4);
            double yZero = (x[1] + y[1] + z[1]) / 3;
            yZero = Math.Round(yZero, 4);
            result.Add(xZero);
            result.Add(yZero);

            return result.ToArray();
        }
    }
}
//https://www.codewars.com/kata/5601c5f6ba804403c7000004/train/csharp