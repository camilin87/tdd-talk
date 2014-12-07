using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            _factorialWebService.GetFactorialFor(n);

            return "really big number";
        }
    }
}
