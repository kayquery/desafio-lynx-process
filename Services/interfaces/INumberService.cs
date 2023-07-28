using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using desafio_lynx_process.Domain.DTOs;
using desafio_lynx_process.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace desafio_lynx_process.Services.interfaces
{
    public interface INumberService
    {
        Task<MathExpression> ExecuteMathExpression(MathExpressionDTO mathExpressionDTO);
        Task<decimal> GetRandomNumber();
    }
}