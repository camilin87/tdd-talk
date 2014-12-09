using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactorialEngine;

namespace FactorialConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var factorialMachine = new FactorialMachine(
                new WebServiceWrapper(),
                new LocalFactorialCalculator());

            var factorial = factorialMachine.Calculate(1000);
            Console.WriteLine("The factorial is {0}", factorial);

            factorial = factorialMachine.Calculate(6);
            Console.WriteLine("The factorial is {0}", factorial);

            Console.ReadLine();
        }
    }
}
