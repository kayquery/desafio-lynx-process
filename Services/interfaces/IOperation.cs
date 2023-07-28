using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_lynx_process.Services.interfaces
{
    public interface IOperation
    {
        decimal ExecuteOperation(decimal firstNumber, decimal secondNumber);
    }
}