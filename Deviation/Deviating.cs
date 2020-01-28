using System;
using StatOps;

namespace Deviation
{
    public class Deviating : IDeviating
    {
        public dynamic solution;

        public dynamic StandDev(dynamic values)
        {
            solution = StatStandardDeviation.StandDev(values);
            return solution;
        }
    }
}
