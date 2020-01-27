using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Tests
{
    [TestClass()]
    public class BasicCalcTests
    {
        private readonly BasicCalc calculator = new BasicCalc();
        [TestMethod()]
        public void AddTest()
        {
            dynamic c = calculator.Add(30, 47);

            Assert.AreEqual(77, c);
            Assert.AreEqual(77, calculator.solution);
        }

        [TestMethod()]
        public void AddIntDoubleTest()
        {
            dynamic c = calculator.Add(2, 2.43);

            Assert.AreEqual(4.43, c);
            Assert.AreEqual(4.43, calculator.solution);
        }

        [TestMethod()]
        public void CubedTest()
        {
            int h = calculator.Cubed(5);

            Assert.AreEqual(125, h);
            Assert.AreEqual(125, calculator.solution);
        }

        [TestMethod()]
        public void DivideTest()
        {
            int d = calculator.Divide(70, 35);

            Assert.AreEqual(2, d);
            Assert.AreEqual(2, calculator.solution);
        }

        [TestMethod()]
        public void TimesTest()
        {
            int c = calculator.Times(8, 5);

            Assert.AreEqual(40, c);
            Assert.AreEqual(40, calculator.solution);
        }

        [TestMethod()]
        public void SquaredTest()
        {
            int f = calculator.Squared(5);

            Assert.AreEqual(25, f);
            Assert.AreEqual(25, calculator.solution);
        }

        [TestMethod()]
        public void SqrtTest()
        {
            double x = calculator.Sqrt(100);

            Assert.AreEqual(10, x);
            Assert.AreEqual(10, calculator.solution);
        }

        [TestMethod()]
        public void DifferenceTest()
        {
            int g = calculator.Difference(60, 47);

            Assert.AreEqual(13, g);
            Assert.AreEqual(13, calculator.solution);
        }
    }
}