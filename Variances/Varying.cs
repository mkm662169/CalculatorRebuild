using System;
using StatOps;

namespace Variances
{
    public class Varying : IVariances
    {
        public dynamic solution;

        public double Variance(dynamic values)
        {
            solution = StatVariance.Variance(values);
            return solution;
        }
    }
}
