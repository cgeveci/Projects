using ConsoleApplication2.Factory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.Factory.MainClasses
{
    class PowerCalculator : IBinaryOperation
    {
        public string oprator
        {
            get
            {
                return "^";
            }
        }
        public decimal Calculate(decimal num1, decimal num2)
        {
            return (decimal)Math.Pow((int)num1, (int)num2);
        }
    }
}
