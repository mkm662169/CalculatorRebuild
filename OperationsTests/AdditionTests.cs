using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operations.Tests
{
    [TestClass()]
    public class AdditionTests
    {
        private readonly int a = 5;
        private readonly int b = 10;
        private readonly double c = 5.7;
        private readonly double d = 4.5;
        private readonly int[] arrayA = { 1, 2, 3, 4 };
        private readonly double[] arrayB = { 1.1, 2.2, 3.3, 4.2 };

        [TestMethod()]
        public void AddIntTest()
        {
            Assert.AreEqual(15, Addition.Add(a, b));
        }

        [TestMethod()]
        public void AddDoubleTest()
        {
            Assert.AreEqual(10.2, Addition.Add(c, d));
        }

        [TestMethod()]
        public void AddArrayTest()
        {
            Assert.AreEqual(10, Addition.Add(arrayA));
        }

        [TestMethod()]
        public void AddDoubleArrayTest()
        {
            Assert.AreEqual(10.8, Addition.Add(arrayB));
        }

        [TestMethod()]
        public void AddIntDoubleTest()
        {
            Assert.AreEqual(9.5, Addition.Add(a, d));
        }
    }
}