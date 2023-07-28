using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using desafio_lynx_process.Domain.Enums;

namespace desafio_lynx_process.Domain.DTOs
{
    public class MathExpressionDTO
    {
        public DateTime Date { get; set; }
        public string Name { get; set;}
        public decimal FirstValue { get; set; }
        public decimal SecondValue { get; set; }
        public EMathOperation MathOperation { get; set; }
    }
}