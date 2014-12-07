namespace FactorialEngine
{
    public class FactorialCalculator
    {
        private readonly IFactorialWebService _factorialWebService;

        public FactorialCalculator(IFactorialWebService factorialWebService)
        {
            _factorialWebService = factorialWebService;
        }

        public string Calculate(int n)
        {
            var url = string.Format("https://murmuring-ravine-8545.herokuapp.com/?n={0}", n);
            return _factorialWebService.GetFactorialFor(url);
        }
    }
}
