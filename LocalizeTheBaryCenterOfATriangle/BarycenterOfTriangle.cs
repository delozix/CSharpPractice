using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalizeTheBaryCenterOfATriangle
{
    internal class BarycenterOfTriangle
    {
        public static double[] BarTriang(double[] x, double[] y, double[] z)
        {
            double[] result = new double[2];
            for (int i = 0; i < 2; i++)
            {
                result[i] = Math.Round(((x[i] + y[i] + z[i]) / 3), 4);
            }
            return result;
        }
    }
}
