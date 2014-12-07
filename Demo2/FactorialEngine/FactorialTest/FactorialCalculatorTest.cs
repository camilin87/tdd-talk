using System;
using FactorialEngine;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;

namespace FactorialTest
{
    [TestClass]
    public class FactorialCalculatorTest
    {
        private IFactorialWebService _factorialWebService;

        [TestInitialize]
        public void Setup()
        {
            _factorialWebService = MockRepository.GenerateMock<IFactorialWebService>();
        }

        [TestMethod]
        public void Calculates20KFactorial()
        {
            var actualValue = new FactorialCalculator(_factorialWebService).Calculate(20000);
            Assert.AreEqual("really big number", actualValue);
        }

        [TestMethod]
        public void ShouldGetTheDataFromAWebservice()
        {
            new FactorialCalculator(_factorialWebService);
        }
    }
}
