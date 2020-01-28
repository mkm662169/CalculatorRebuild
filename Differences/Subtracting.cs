using System;
using Operations;

namespace Differences
{
    public class Subtracting : IDifferences
    {
        public dynamic solution;
        public dynamic Difference(dynamic a, dynamic b)
        {
            solution = Subtraction.Difference(a, b);
            return solution;
        }

        public dynamic Difference(dynamic a)
        {
            solution = Subtraction.Difference(a);
            return solution;
        }
    }
}
