using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatOps;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatOps.Tests
{
    [TestClass()]
    public class StatZScoreTests
    {
        [TestMethod()]
        public void ZScoreTest()
        {
            int[] values = { 1, 2, 3, 4, 5 };
            int score = 2;
            var zScore = StatZScore.ZScore(score, values);
            Assert.AreEqual(-0.70711, Helpers.Rounding.RoundToFive(zScore));
        }
    }
}