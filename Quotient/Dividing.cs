using System;
using Operations;

namespace Quotient
{
    public class Dividing : IDivides
    {
        public dynamic solution;
        public dynamic Divide(dynamic a, dynamic b)
        {
            solution = Division.Divide(a, b);
            return solution;
        }
    }
}
