using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using desafio_lynx_process.Controllers.Base;
using desafio_lynx_process.Domain.DTOs;
using desafio_lynx_process.Domain.Entities;
using desafio_lynx_process.Services.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace desafio_lynx_process.Controllers
{
    public class NumberController : BaseController
    {
        private readonly INumberService _numberService;

        public NumberController(INumberService numberService)
            => _numberService = numberService;
        

        [HttpGet]
        [ProducesResponseType(typeof(object), 200)]
        public async Task<IActionResult> GetRandomNumber()
            => Ok(new { RandomNumber = await _numberService.GetRandomNumber()}); 

        [HttpPost]
        [ProducesResponseType(typeof(MathExpression), 200)]
        [ProducesResponseType(typeof(BadRequestObjectResult), 400)]
        public async Task<IActionResult> ExecuteMathExpression([FromBody] MathExpressionDTO mathExpressionDTO) 
        {
            try
            {
                MathExpression mathExpression = await _numberService.ExecuteMathExpression(mathExpressionDTO);
                return Ok(mathExpression);   
            }
            catch ( HttpRequestException ex)
            {
                return BadRequest(ex);
            }
            catch 
            {
                return BadRequest(new HttpRequestException("Some error happen"));
            }
        }
    }
}