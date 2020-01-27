using System;
using Operations;

namespace Cubing
{
    public class Cubes : ICubing
    {
        public dynamic solution;

        public dynamic Cubed(dynamic a)
        {
            solution = Cube.Cubed(a);
            return solution;
        }
    }
}
