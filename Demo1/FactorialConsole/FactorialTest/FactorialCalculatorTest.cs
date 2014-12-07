using System;
using FactorialEngine;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FactorialTest
{
    [TestClass]
    public class FactorialCalculatorTest
    {
        [TestMethod]
        public void ZeroFactorialShouldBeOne()
        {
            var actualResult = new FactorialCalculator().Calculate(0);

            Assert.AreEqual(1, actualResult);
        }
    }
}
