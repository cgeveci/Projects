using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.Factory.Interface
{
    interface IBinaryOperation : IOperation
    {        
        decimal Calculate(decimal num1, decimal num2);       
    }
}
