using System;
using Operations;

namespace SquareRoot
{
    public class SquareRoots : ISquareRooting
    {
        public dynamic solution;

        public dynamic Sqrt(dynamic a)
        {
            solution = Root.Sqrt(a);
            return solution;
        }
    }
}
