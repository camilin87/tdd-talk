using System;
using FactorialEngine;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FactorialEngineTest
{
    [TestClass]
    public class FactorialCalculatorTest
    {
        [TestMethod]
        public void CallsTheFactorialWebService()
        {
            new FactorialCalculator().Calculate(1000);
        }
    }
}
