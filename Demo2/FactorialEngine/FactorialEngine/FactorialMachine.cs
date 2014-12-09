
namespace FactorialEngine
{
    public class FactorialMachine
    {
        private readonly IWebServiceWrapper _webService;
        private readonly ILocalFactorialCalculator _localFactorialCalculator;

        public FactorialMachine(IWebServiceWrapper webService, ILocalFactorialCalculator localFactorialCalculator)
        {
            _webService = webService;
            _localFactorialCalculator = localFactorialCalculator;
        }

        public string Calculate(int number)
        {
            if (number == 6)
            {
                return _localFactorialCalculator.Calculate(number).ToString();
            }

            return _webService.ReadUrl(string.Format("https://murmuring-ravine-8545.herokuapp.com/?n={0}", number));
        }
    }
}