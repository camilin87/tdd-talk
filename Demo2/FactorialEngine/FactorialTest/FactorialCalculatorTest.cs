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
        private FactorialCalculator _factorialCalculator;

        [TestInitialize]
        public void Setup()
        {
            _factorialWebService = MockRepository.GenerateMock<IFactorialWebService>();
            _factorialCalculator = new FactorialCalculator(_factorialWebService);
        }

        [TestMethod]
        public void Calculates20KFactorial()
        {
            var actualValue = _factorialCalculator.Calculate(20000);
            Assert.AreEqual("really big number", actualValue);
        }

        [TestMethod]
        public void ShouldGetTheDataFromTheFactorialWebService()
        {
            _factorialCalculator.Calculate(3);

            _factorialWebService.AssertWasCalled(s => s.GetFactorialFor(3));
        }
    }
}
