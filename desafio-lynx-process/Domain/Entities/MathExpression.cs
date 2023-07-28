using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using desafio_lynx_process.Domain.DTOs;
using desafio_lynx_process.Domain.Enums;
using desafio_lynx_process.Services.interfaces;
using desafio_lynx_process.Services.Operations;

namespace desafio_lynx_process.Domain.Entities
{
    public class MathExpression
    {
        public MathExpression(MathExpressionDTO expressionDTO)
        {
            IOperation operation = expressionDTO.MathOperation switch
            {
                EMathOperation.Addition => new AddOperation(),
                EMathOperation.Division => new DivOperation(),
                EMathOperation.Multiplication => new MultiOperation(),
                EMathOperation.Subtraction => new SubOperation(),
                _ => throw new ArgumentException("Some problem happen with you math expression")

            };

            FirstValue = expressionDTO.FirstValue;
            SecondValue = expressionDTO.SecondValue;
            MathOperation = expressionDTO.MathOperation; 

            Result = operation.ExecuteOperation(FirstValue, SecondValue);
            
            Date = expressionDTO.Date;
            Name = expressionDTO.Name;

        }

        public DateTime Date { get; }
        public string Name { get; }
        public decimal FirstValue { get; }
        public decimal SecondValue { get; }
        public EMathOperation MathOperation { get; }
        public decimal Result { get; }

    }

}