using ConsoleApplication2.Factory;
using ConsoleApplication2.Factory.Interface;
using ConsoleApplication2.Factory.MainClasses;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class RPNCalculator
    {
        public List<IBinaryOperation> BinaryOperators { get; set; }
        public List<IUnaryOperation> UnaryOperators { get; set; }


        public RPNCalculator()
        {
            BinaryOperators = new List<IBinaryOperation> { new DivisionCalculator(), new MultiplyCalculator(), new MinusCalculator(), new PlusCalculator(), new PowerCalculator() };
            UnaryOperators = new List<IUnaryOperation> { new FactorialCalculator() };
        }

        public decimal CalculateRPN(string rpnExpression)
        {
            decimal result = 0;
            decimal number = 0;
            

            Stack<decimal> stack = new Stack<decimal>();

            foreach (string str in rpnExpression.Split(','))
            {
                if (decimal.TryParse(str, out number))
                {
                    stack.Push(number);
                }
                else
                {
                    if (string.IsNullOrEmpty(str))
                        throw new InvalidOperationException();

                    foreach(var binaryOperator in BinaryOperators.Where(x=>x.oprator == str))
                    {
                        stack.Push(binaryOperator.Calculate(stack.Pop(), stack.Pop()));
                    }

                    foreach (var unaryOperator in UnaryOperators.Where(x => x.oprator == str))
                    {
                        stack.Push(unaryOperator.Calculate(stack.Pop()));
                    }
                }
            }
            return stack.Pop();
        }
    }
}
