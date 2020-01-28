using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsScore
{
    public interface IZScores
    {
        public dynamic ZScore(dynamic score, dynamic values);
    }
}
