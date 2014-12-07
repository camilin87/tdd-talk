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
            if (n < 20)
            {
                return CalculateFactorialLocally(n).ToString();
            }

            return CalculateFactorialRemotely(n);
        }

        private string CalculateFactorialRemotely(int n)
        {
            var url = string.Format("https://murmuring-ravine-8545.herokuapp.com/?n={0}", n);
            return _factorialWebService.GetFactorialFor(url);
        }

        private int CalculateFactorialLocally(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            return n * CalculateFactorialLocally(n - 1);
        }
    }

}
