using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operations.Tests
{
    [TestClass()]
    public class DivisionTests
    {
        private readonly int a = 55;
        private readonly int b = 5;
        private readonly double c = 5.7;
        private readonly double d = 2.4;
        private readonly int e = 0;

        [TestMethod()]
        public void DivideTest()
        {
            Assert.AreEqual(11, Division.Divide(a, b));
        }

        [TestMethod()]
        public void DivideDoubleTest()
        {
            Assert.AreEqual(2.375, Division.Divide(c, d));
        }
    }
}