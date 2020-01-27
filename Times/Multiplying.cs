using System;
using Operations;

namespace Times
{
    public class Multiplying : IMultiplying
    {
        public dynamic solution;
        public dynamic Times(dynamic a, dynamic b)
        {
            solution = Multiplication.Times(a, b);
            return solution;
        }
        public dynamic Times(dynamic values)
        {
            solution = Multiplication.Times(values);
            return solution;
        }
    }
}
