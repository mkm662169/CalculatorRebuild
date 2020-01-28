using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;
using System.Collections.Generic;
using System.Text;
 

namespace Calculator.Tests
{
    [TestClass()]
    public class StatsCalcTests
    {
        private readonly StatsCalc statsCalc = new StatsCalc();

        [TestMethod()]
        public void MeanTest()
        {
            int[] values = { 1, 2, 3, 4, 5 };
            var mean = statsCalc.Mean(values);
            Assert.AreEqual(3, mean);
        }

        [TestMethod()]
        public void VarianceTest()
        {
            int[] values = { 1, 2, 3, 4, 5 };
            var variance = statsCalc.Variance(values);
            Assert.AreEqual(2, variance);
        }

        [TestMethod()]
        public void StandDevTest()
        {
            int[] values = { 1, 2, 3, 4, 5 };
            var stdv = statsCalc.StandDev(values);
            Assert.AreEqual(1.41421, Helpers.Rounding.RoundToFive(stdv));
        }

        [TestMethod()]
        public void ZScoreTest()
        {
            int[] values = { 1, 2, 3, 4, 5 };
            int score = 4;
            var zScore = statsCalc.ZScore(score, values);
            Assert.AreEqual(0.70711, Helpers.Rounding.RoundToFive(zScore));
        }
    }
}