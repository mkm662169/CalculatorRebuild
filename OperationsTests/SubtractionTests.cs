using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operations.Tests
{
    [TestClass()]
    public class SubtractionTests
    {
        private readonly int a = 40;
        private readonly int b = 37;
        private readonly double c = 6.7;
        private readonly double d = 4.5;

        [TestMethod()]
        public void DifferenceTest()
        {
            Assert.AreEqual(3, Subtraction.Difference(a, b));
        }

        [TestMethod()]
        public void DifferenceDoubleTest()
        {
            Assert.AreEqual(2.2, Subtraction.Difference(c, d));
        }
    }
}