using System;
using StatOps;

namespace PersonsScore
{
    public class ZScores : IZScores
    {
        public dynamic solution;

        public dynamic ZScore(dynamic score, dynamic values)
        {
            solution = StatZScore.ZScore(score, values);
            return solution;
        }
    }
}
