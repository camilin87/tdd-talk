
namespace FactorialEngine
{
    public class FactorialCalculator
    {
        private readonly IWebServiceWrapper _webService;

        public FactorialCalculator(IWebServiceWrapper webService)
        {
            _webService = webService;
        }

        public void Calculate(int number)
        {
            _webService.ReadUrl(string.Format("https://murmuring-ravine-8545.herokuapp.com/?n={0}", number));
        }
    }
}