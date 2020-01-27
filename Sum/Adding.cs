using System;
using Operations;

namespace Sum
{
    public class Adding : IAdd
    {
        public dynamic solution;
        public dynamic Add(dynamic a, dynamic b)
        {
            solution = Addition.Add(a, b);
            return solution;
        }
        public dynamic Add(dynamic values)
        {
            solution = Addition.Add(values);
            return solution;
        }
    }
}
