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
        public void ShouldReturnTheFactorialWebServiceResult()
        {
            _factorialWebService.Stub(s => s.GetFactorialFor(
                "https://murmuring-ravine-8545.herokuapp.com/?n=1000"))
                .Return("very big number");

            var actualResult = _factorialCalculator.Calculate(1000);
            
            Assert.AreEqual("very big number", actualResult);
        }

        [TestMethod]
        public void DoesNotCallTheWebServiceForNumbersSmallerThan20()
        {
            for (var i = 19; i >= 0; i--)
            {
                _factorialCalculator.Calculate(i);
            }

            _factorialWebService.AssertWasNotCalled(s => s.GetFactorialFor(Arg<string>.Is.Anything));
        }

        [TestMethod]
        public void CalculatesFactorialOfZeroLocally()
        {
            var actualValue = _factorialCalculator.Calculate(0);
            Assert.AreEqual("1", actualValue);
        }

        [TestMethod]
        public void CalculatesFactorialOfOneLocally()
        {
            var actualValue = _factorialCalculator.Calculate(2);
            Assert.AreEqual("2", actualValue);
        }

        [TestMethod]
        public void CalculatesFactorialOfThreeLocally()
        {
            var actualValue = _factorialCalculator.Calculate(3);
            Assert.AreEqual("6", actualValue);
        }
    }
}
