using System;
using System.Collections.Generic;
using System.Text;
using Operations;

namespace StatOps
{
    public class StatStandardDeviation
    {
        public static double StandDev(dynamic values)
        {
            double variance = StatVariance.Variance(values);
            double standDev = Root.Sqrt(variance);

            return standDev;
        }
    }
}
