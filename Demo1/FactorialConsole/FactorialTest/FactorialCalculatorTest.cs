using System;
using System.Security.Cryptography.X509Certificates;
using FactorialEngine;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FactorialTest
{
    [TestClass]
    public class FactorialCalculatorTest
    {
        private FactorialCalculator _factorialCalculator;

        [TestInitialize]
        public void Setup()
        {
            _factorialCalculator = new FactorialCalculator();
        }

        private void FactorialOf(int number, int shouldBe)
        {
            var actualFactorial = _factorialCalculator.Calculate(number);
            var expectedFactorial = shouldBe;

            Assert.AreEqual(expectedFactorial, actualFactorial);
        }

        [TestMethod]
        public void ZeroFactorialShouldBeOne()
        {
            FactorialOf(0, shouldBe: 1);
        }

        [TestMethod]
        public void TwoFactorialShouldBeTwo()
        {
            FactorialOf(2, shouldBe: 2);
        }

        [TestMethod]
        public void ThreeFactorialShouldBeSix()
        {
            FactorialOf(3, shouldBe: 6);
        }
    }
}
