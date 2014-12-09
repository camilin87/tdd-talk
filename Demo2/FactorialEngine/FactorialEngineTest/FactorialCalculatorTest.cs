using System;
using FactorialEngine;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;

namespace FactorialEngineTest
{
    [TestClass]
    public class FactorialCalculatorTest
    {
        [TestMethod]
        public void CallsTheFactorialWebService()
        {
            var webService = MockRepository.GenerateMock<IWebServiceWrapper>();

            new FactorialCalculator(webService).Calculate(1000);

            webService.AssertWasCalled(w => w.ReadUrl("https://murmuring-ravine-8545.herokuapp.com/?n=1000"));
        }
    }
}
