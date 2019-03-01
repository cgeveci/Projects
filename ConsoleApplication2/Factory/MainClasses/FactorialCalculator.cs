using ConsoleApplication2.Factory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.Factory.MainClasses
{
    class FactorialCalculator : IUnaryOperation
    {
        public string oprator
        {
            get
            {
                return "!";
            }
        }
        public decimal Calculate(decimal num1)
        {
            decimal result = 1;
            while (num1 != 1)
            {
                result *= num1;
                num1--;
            }
            return result;
        }
    }
}
