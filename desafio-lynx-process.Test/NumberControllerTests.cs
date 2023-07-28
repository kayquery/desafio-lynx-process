using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using desafio_lynx_process.Controllers;
using desafio_lynx_process.Domain.DTOs;
using desafio_lynx_process.Domain.Entities;
using desafio_lynx_process.Domain.Enums;
using desafio_lynx_process.Services;

namespace desafio_lynx_process.Test
{
    public class NumberControllerTests
    {
        private NumberService _numberService;

        public NumberControllerTests()
        {
            _numberService = new NumberService();
        }

        [Fact]
        public async void GetRandomNumber_ReturnsOkResultWithRandomNumber()
        {
            var number = await _numberService.GetRandomNumber();

            Assert.NotNull(number);
            Assert.IsType<decimal>(number);
        }

        [Fact]
        public async void ExecuteMathExpression_ValidInput_ReturnsSameData()
        {
            //Arrange
            var mathExpressionDTO = new MathExpressionDTO() {
                Date = DateTime.Now,
                FirstValue = 2,
                SecondValue = 5,
                MathOperation = EMathOperation.Addition,
                Name="Adition operation try"
            };

            MathExpression mathExpression = await _numberService.ExecuteMathExpression(mathExpressionDTO);

            Assert.Equal(mathExpressionDTO.Date, mathExpression.Date);
            Assert.Equal(mathExpressionDTO.Name, mathExpression.Name);
            Assert.Equal(mathExpressionDTO.MathOperation, mathExpression.MathOperation);
            Assert.Equal(mathExpressionDTO.FirstValue, mathExpression.FirstValue);
            Assert.Equal(mathExpressionDTO.SecondValue, mathExpression.SecondValue);
        }
    
        [Fact]
        public async void ExecuteMathExpression_ValidInput_ReturnsAdd()
        {
            var mathExpressionDTO = new MathExpressionDTO() {
                Date = DateTime.Now,
                FirstValue = 2,
                SecondValue = 5,
                MathOperation = EMathOperation.Addition,
                Name="Adition operation try"
            };

            MathExpression mathExpression = await _numberService.ExecuteMathExpression(mathExpressionDTO);
            Assert.Equal(mathExpressionDTO.FirstValue + mathExpressionDTO.SecondValue, mathExpression.Result);
        }
        [Fact]
        public async void ExecuteMathExpression_ValidInput_ReturnsSub()
        {
            var mathExpressionDTO = new MathExpressionDTO() {
                Date = DateTime.Now,
                FirstValue = 2,
                SecondValue = 5,
                MathOperation = EMathOperation.Subtraction,
                Name="Subtraction operation try"
            };

            MathExpression mathExpression = await _numberService.ExecuteMathExpression(mathExpressionDTO);
            Assert.Equal(mathExpressionDTO.FirstValue - mathExpressionDTO.SecondValue, mathExpression.Result);
        }
        [Fact]
        public async void ExecuteMathExpression_ValidInput_ReturnsMult()
        {
            var mathExpressionDTO = new MathExpressionDTO() {
                Date = DateTime.Now,
                FirstValue = 2,
                SecondValue = 5,
                MathOperation = EMathOperation.Multiplication,
                Name="Multiplication operation try"
            };

            MathExpression mathExpression = await _numberService.ExecuteMathExpression(mathExpressionDTO);
            Assert.Equal(mathExpressionDTO.FirstValue * mathExpressionDTO.SecondValue, mathExpression.Result);
        }
        [Fact]
        public async void ExecuteMathExpression_ValidInput_ReturnsDiv()
        {
            var mathExpressionDTO = new MathExpressionDTO() {
                Date = DateTime.Now,
                FirstValue = 2,
                SecondValue = 5,
                MathOperation = EMathOperation.Division,
                Name="Division operation try"
            };

            MathExpression mathExpression = await _numberService.ExecuteMathExpression(mathExpressionDTO);
            Assert.Equal(mathExpressionDTO.FirstValue / mathExpressionDTO.SecondValue, mathExpression.Result);
        }

    }
}