using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using desafio_lynx_process.Domain.DTOs;
using desafio_lynx_process.Domain.Entities;
using desafio_lynx_process.Domain.Enums;
using desafio_lynx_process.Services.interfaces;
using desafio_lynx_process.Services.Operations;
using Microsoft.AspNetCore.Mvc;

namespace desafio_lynx_process.Services
{
    public class NumberService : INumberService
    {

        private readonly Random _random = new Random();


        public async Task<decimal> GetRandomNumber()
            => _random.Next(1, 100);

        public async Task<MathExpression> ExecuteMathExpression(MathExpressionDTO mathExpressionDTO)
        {
            try
            {
                return new MathExpression(mathExpressionDTO);
            }
            catch (ArgumentException ex)
            {
                throw new HttpRequestException(ex.Message);
            }
            catch
            {
                throw;
            }
        }

    }
}