using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operations.Tests
{
    [TestClass()]
    public class CubeTests
    {
        private readonly int a = 5;
        private readonly double b = 5.5;

        [TestMethod()]
        public void CubedTest()
        {
            Assert.AreEqual(125, Cube.Cubed(a));
        }

        [TestMethod()]
        public void CubedDoubleTest()
        {
            Assert.AreEqual(166.375, Cube.Cubed(b));
        }
    }
}