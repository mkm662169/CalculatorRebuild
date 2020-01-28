using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatOps;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatOps.Tests
{
    [TestClass()]
    public class StatStandardDeviationTests
    {
        [TestMethod()]
        public void StandDevTest()
        {
            int[] values = { 1, 2, 3, 4, 5 };
            var standDev = StatStandardDeviation.StandDev(values);
            Assert.AreEqual(1.41421, Helpers.Rounding.RoundToFive(standDev));
        }
    }
}