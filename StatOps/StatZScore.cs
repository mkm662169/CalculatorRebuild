using System;
using System.Collections.Generic;
using System.Text;
using Operations;

namespace StatOps
{
    public class StatZScore
    {
        public static dynamic ZScore(dynamic score, dynamic values)
        {
            double mean = StatMean.Mean(values);
            double stdDev = StatStandardDeviation.StandDev(values);
            double zScore = Division.Divide(Subtraction.Difference(score, mean), stdDev);
            return zScore;
        }
    }
}
