using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operations.Tests
{
    [TestClass()]
    public class SquareTests
    {
        private readonly dynamic a = 9;
        private readonly dynamic b = 1.1;

        [TestMethod()]
        public void SquaredTest()
        {
            Assert.AreEqual(81, Square.Squared(a));
        }

        [TestMethod()]
        public void SquaredDoubleTest()
        {
            Assert.AreEqual(1.2100000000000002, Square.Squared(b));
        }
    }
}