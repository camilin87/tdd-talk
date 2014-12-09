
namespace FactorialEngine
{
    public class FactorialCalculator
    {
        private readonly IWebServiceWrapper _webService;

        public FactorialCalculator(IWebServiceWrapper webService)
        {
            _webService = webService;
        }

        public string Calculate(int number)
        {
            return _webService.ReadUrl(string.Format("https://murmuring-ravine-8545.herokuapp.com/?n={0}", number));
        }
    }
}