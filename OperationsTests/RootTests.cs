using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operations.Tests
{
    [TestClass()]
    public class RootTests
    {
        private readonly dynamic a = 100;
        private readonly dynamic b = 10.1;

        [TestMethod()]
        public void SqrtTest()
        {
            Assert.AreEqual(10, Root.Sqrt(a));
        }
        [TestMethod()]
        public void SqrtDoubleTest()
        {
            Assert.AreEqual(3.1780497164141406804582045589355, Root.Sqrt(b));
        }
    }
}