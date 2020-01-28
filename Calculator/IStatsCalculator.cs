using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public interface IStatsCalculator
    {
        public dynamic Mean(dynamic values);

        public double Variance(dynamic values);

        public dynamic StandDev(dynamic values);

        public dynamic ZScore(dynamic score, dynamic values);
    }
}
