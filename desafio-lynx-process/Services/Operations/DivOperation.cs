using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using desafio_lynx_process.Services.interfaces;

namespace desafio_lynx_process.Services.Operations
{
    public class DivOperation : IOperation
    {
        public decimal ExecuteOperation(decimal firstNumber, decimal secondNumber)
        {
            if(secondNumber == 0)
                throw new DivideByZeroException();

            return firstNumber/secondNumber;
        }
    }
}