using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public interface IBasicCalc
    {
        public dynamic Add(dynamic a, dynamic b);
        public dynamic Add(dynamic values);
        public dynamic Cubed(dynamic a);
        public dynamic Difference(dynamic a, dynamic b);
        public dynamic Difference(dynamic a);
        public dynamic Times(dynamic a, dynamic b);
        public dynamic Times(dynamic values);
        public dynamic Divide(dynamic a, dynamic b);
        public dynamic Square(dynamic a);
        public dynamic Sqrt(dynamic a);

    }
}
