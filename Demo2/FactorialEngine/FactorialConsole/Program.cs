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
            var factorialResult = new FactorialCalculator(new FactorialWebService())
                .Calculate(1000);
            
            Console.WriteLine("The factorial is {0}", factorialResult);
            Console.ReadLine();
        }
    }
}
