using System;

namespace Square
{
    public class Squares : ISquared
    {
        public dynamic solution;

        public dynamic Squared(dynamic a)
        {
            solution = a * a;
            return solution;
        }
    }
}
