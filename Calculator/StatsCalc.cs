using System;
using System.Collections.Generic;
using System.Text;
using StatOps;
using Average;
using Deviation;
using Variances;
using PersonsScore;

namespace Calculator
{
    public class StatsCalc : IAverage, IDeviating, IVariances, IZScores
    {
        readonly Averaging mean = new Averaging();
        readonly Varying variance = new Varying();
        readonly Deviating standDev = new Deviating();
        readonly ZScores zscore = new ZScores();

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

        public dynamic ZScore(dynamic score, dynamic values)
        {
            solution = StatZScore.ZScore(score, values);
            return solution;
        }

    }
}
