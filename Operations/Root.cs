using System;
using System.Collections.Generic;
using System.Text;

namespace Operations
{
    public class Root
    {
        public static double Sqrt(int a)
        {
            return Math.Pow(a, 1.0/2.0);
        }
        public static double Sqrt(double a)
        {
            return Math.Pow(a, 1.0 / 2.0);
        }
    }
}
