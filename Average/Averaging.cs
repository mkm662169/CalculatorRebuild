using System;
using System.Collections.Generic;
using System.Text;
using StatOps;

namespace Average
{
    public class Averaging : IAverage
    {
        public dynamic solution;

        public dynamic Mean(dynamic values)
        {
            solution = StatMean.Mean(values);
            return solution;
        }
    }
}
