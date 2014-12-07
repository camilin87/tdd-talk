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
    }
}
