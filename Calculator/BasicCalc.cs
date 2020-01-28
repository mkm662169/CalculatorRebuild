using System;
using Operations;
using Sum;
using Differences;
using Quotient;
using Times;
using SquareRoot;
using Cubing;
using Square;

namespace Calculator
{
    public class BasicCalc : IAdd, IDifferences, IDivides, IMultiplying, ISquared, ICubing
    {
        readonly Adding add = new Adding();
        readonly Subtracting subtract = new Subtracting();
        readonly Dividing divide = new Dividing();
        readonly Multiplying multiply = new Multiplying();
        readonly SquareRoots squareRoots = new SquareRoots();
        readonly Cubes cubes = new Cubes();
        readonly Squares square = new Squares();

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
            solution = Operations.Square.Squared(a);
            return solution;
        }
        public double Sqrt(double a)
        {
            solution = Root.Sqrt(a);
            return solution;
        }
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
