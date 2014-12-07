using System;
using FactorialEngine;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FactorialTest
{
    [TestClass]
    public class FactorialCalculatorTest
    {
        [TestMethod]
        public void Calculates20KFactorial()
        {
            var actualValue = new FactorialCalculator().Calculate(20000);
            Assert.AreEqual("really big number", actualValue);
        }
    }
}
