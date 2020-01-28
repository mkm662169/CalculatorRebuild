using System;
using System.Collections.Generic;
using System.Text;
using StatOps;
using Average;
using Deviation;
using Variances;

namespace Calculator
{
    public class StatsCalc : IAverage, IDeviating, IVariances
    {
        readonly Averaging mean = new Averaging();
        readonly Varying variance = new Varying();
        readonly Deviating standDev = new Deviating();

        public dynamic solution;

        public dynamic Mean(dynamic values)
        {
            solution = StatMean.Mean(values);
            return solution;
        }

        public double Variance(dynamic values)
        {
            solution = StatVariance.Variance(values);
            return solution;
        }

        public dynamic StandDev(dynamic values)
        {
            solution = StatStandardDeviation.StandDev(values);
            return solution;
        }

    }
}
