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
            Console.WriteLine("Factorial App");
            Console.WriteLine(new FactorialCalculator().Calculate(4));
            Console.ReadLine();
        }
    }
}
