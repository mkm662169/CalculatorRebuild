using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operations.Tests
{
    [TestClass()]
    public class MultiplicationTests
    {
        private readonly int a = 5;
        private readonly int b = 7;
        private readonly double c = 5.7;
        private readonly double d = 8.3;
        private readonly int[] arrayA = { 1, 2, 3, 4 };
        private readonly double[] arrayB = { 1.1, 2.2, 3.3, 4.4 };

        [TestMethod()]
        public void TimesTest()
        {
            Assert.AreEqual(35, Multiplication.Times(a, b));
        }

        [TestMethod()]
        public void TimesDoubleTest()
        {
            Assert.AreEqual(47.31, Multiplication.Times(c,d));
        }

        [TestMethod()]
        public void TimesIntArrayTest()
        {
            Assert.AreEqual(24, Multiplication.Times(arrayA));
        }

        [TestMethod()]
        public void TimesDoubleArrayTest()
        {
            Assert.AreEqual(35.138400000000004, Multiplication.Times(arrayB));
        }
    }
}