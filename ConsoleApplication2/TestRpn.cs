using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Collections;

namespace ConsoleApplication2
{
    [TestFixture]
    public class TestRpn
    {
        [Test]
        
        public void SimpleRPNOperationWithoutOperator()
        {
            string rpnExp = "6,4";
            RPNCalculator calc = new RPNCalculator();

            calc.CalculateRPN(rpnExp);

            //Assert.Throws(InvalidOperationException, new TestDelegate());
        }

        // Calculates the minus operation between two number
        [Test]
        public void SimpleRPNOperationWithDecimal()
        {
            string rpnExp = "6,4,-";
            RPNCalculator calc = new RPNCalculator();

            Assert.AreEqual(-2, calc.CalculateRPN(rpnExp));
        }

        [Test]
        public void SimpleRPNOperationWithPower()
        {
            string rpnExp = "2,3,^";
            RPNCalculator calc = new RPNCalculator();
               
            Assert.AreEqual(9, calc.CalculateRPN(rpnExp));
        }

        [Test]
        public void SimpleRPNOperationWithFactorial()
        {
            string rpnExp = "4,!";
            RPNCalculator calc = new RPNCalculator();

            Assert.AreEqual(24, calc.CalculateRPN(rpnExp));
        }
    }
}
