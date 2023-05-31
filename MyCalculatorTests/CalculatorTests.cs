using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void SumTest()
        {
            var calculator = new Calculator();
            Assert.IsTrue(calculator.Sum(2, 2) == 4);
            
        }

        [TestMethod()]
        public void SubstractTest()
        {
            var calculator = new Calculator();
            Assert.IsTrue(calculator.Substract(8, 2) == 6);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            var calculator = new Calculator();
            Assert.IsTrue(calculator.Multiply(2, 3) == 6);
        }

        [TestMethod()]
        public void DivideTest()
        {
            var calculator = new Calculator();
            Assert.IsTrue(calculator.Divide(2, 2) == 1);
        }
    }
}