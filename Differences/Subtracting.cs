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
    }
}
