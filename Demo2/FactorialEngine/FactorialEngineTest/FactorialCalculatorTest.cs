using FactorialEngine;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;

namespace FactorialEngineTest
{
    [TestClass]
    public class FactorialCalculatorTest
    {
        [TestMethod]
        public void CallsAWebServiceToCalculateTheFactorial()
        {
            var webService = MockRepository.GenerateMock<IWebServiceWrapper>();
            webService.Stub(w => w.ReadUrl("https://murmuring-ravine-8545.herokuapp.com/?n=1000"))
                .Return("my- factorial");

            var actualResult = new FactorialCalculator(webService).Calculate(1000);

            Assert.AreEqual("my- factorial", actualResult);
        }
    }
}
