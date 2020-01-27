using System;
using Operations;

namespace Calculator
{
    public class BasicCalc
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
        public dynamic Cubed(dynamic a)
        {
            solution = Cube.Cubed(a);
            return solution;
        }
        public dynamic Divide(dynamic a, dynamic b)
        {
            solution = Division.Divide(a, b);
            return solution;
        }
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
        public dynamic Squared(dynamic a)
        {
            solution = Square.Squared(a);
            return solution;
        }
        public double Sqrt(double a)
        {
            solution = SquareRoot.Sqrt(a);
            return solution;
        }
        public dynamic Difference(dynamic a, dynamic b)
        {
            solution = Subtraction.Difference(a, b);
            return solution;
        }
    }
}
