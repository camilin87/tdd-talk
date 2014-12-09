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

        [TestMethod]
        public void ReadsTheWebServiceResult()
        {
            var webService = MockRepository.GenerateMock<IWebServiceWrapper>();
            webService.Stub(w => w.ReadUrl(Arg<string>.Is.Anything)).Return("my factorial");

            var actualResult = new FactorialCalculator(webService).Calculate(1000);

            Assert.AreEqual("my factorial", actualResult);
        }
    }
}
