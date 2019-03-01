using ConsoleApplication2.Factory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.Factory.MainClasses
{
    class PlusCalculator : IBinaryOperation
    {
        public string oprator
        {
            get
            {
                return "+";
            }
        }

        decimal IBinaryOperation.Calculate(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
    }
}
