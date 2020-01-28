using System;
using System.Collections.Generic;
using System.Text;

namespace Differences
{
    public interface IDifferences
    {
        public dynamic Difference(dynamic a, dynamic b);

        public dynamic Difference(dynamic a);
    }
}
