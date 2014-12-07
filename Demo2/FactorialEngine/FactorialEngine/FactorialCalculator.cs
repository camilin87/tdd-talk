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
            return _factorialWebService.GetFactorialFor(n);
        }
    }
}
