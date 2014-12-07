namespace FactorialEngine
{
    public class FactorialCalculator
    {
        private readonly IFactorialWebService _factorialWebService;
        private readonly FactorialLocalCalculator _factorialLocalCalculator;

        public FactorialCalculator(IFactorialWebService factorialWebService)
        {
            _factorialWebService = factorialWebService;
            _factorialLocalCalculator = new FactorialLocalCalculator();
        }

        public string Calculate(int n)
        {
            if (n < 20)
            {
                return _factorialLocalCalculator.Calculate(n).ToString();
            }

            return CalculateFactorialRemotely(n);
        }

        private string CalculateFactorialRemotely(int n)
        {
            var url = string.Format("https://murmuring-ravine-8545.herokuapp.com/?n={0}", n);
            return _factorialWebService.GetFactorialFor(url);
        }
    }

}
