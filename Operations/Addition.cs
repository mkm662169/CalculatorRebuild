using System;

namespace Operations
{
    public class Addition
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static double Add(double a, double b)
        {
            return a + b;
        }
        public static int Add(int[] arrayA)
        {
            int c = 0;
            foreach(int a in arrayA)
            {
                c = Add(c, a);
            }
            return c;
        }
        public static double Add(double[] arrayA)
        {
            double c = 0.0;
            foreach(double a in arrayA)
            {
                c = Add(c, a);
            }
            return c;
        }
    }
}
