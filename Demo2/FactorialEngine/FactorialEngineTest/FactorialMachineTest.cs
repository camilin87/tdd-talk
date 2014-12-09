using FactorialEngine;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;

namespace FactorialEngineTest
{
    [TestClass]
    public class FactorialMachineTest
    {
        [TestMethod]
        public void CallsAWebServiceToCalculateTheFactorial()
        {
            var webService = MockRepository.GenerateMock<IWebServiceWrapper>();
            webService.Stub(w => w.ReadUrl("https://murmuring-ravine-8545.herokuapp.com/?n=1000"))
                .Return("my- factorial");

            var actualResult = new FactorialMachine(webService, null).Calculate(1000);

            Assert.AreEqual("my- factorial", actualResult);
        }

        [TestMethod]
        public void CalculatesFactorialLocallyForSmallNumbers()
        {
            var localFactorialCalculator = MockRepository.GenerateMock<ILocalFactorialCalculator>();
            localFactorialCalculator.Stub(c => c.Calculate(6)).Return(45678);

            var actualResult = new FactorialMachine(null, localFactorialCalculator).Calculate(6);
            
            Assert.AreEqual("45678", actualResult);
        }
    }
}
