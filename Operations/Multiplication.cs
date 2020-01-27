using System;
using System.Collections.Generic;
using System.Text;

namespace Operations
{
    public class Multiplication
    {
        public static int Times(int a, int b)
        {
            return a * b;
        }
        public static double Times(double a, double b)
        {
            return a * b;
        }
        public static int Times(int[] arrayA)
        {
            dynamic c = 1;
            foreach (dynamic a in arrayA)
            {
                c = Times(c, a);
            }
            return c;
        }
        public static double Times(double[] arrayA)
        {
            double c = 1;
            foreach (double a in arrayA)
            {
                c = Times(c, a);
            }
            return c;
        }
    }
}
