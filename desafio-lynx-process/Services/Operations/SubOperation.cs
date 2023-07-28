using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using desafio_lynx_process.Services.interfaces;

namespace desafio_lynx_process.Services.Operations
{
    public class SubOperation : IOperation
    {
        public decimal ExecuteOperation(decimal firstNumber, decimal secondNumber)
            => firstNumber - secondNumber;
    }
}