using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{operation}/{firstNumber}/{secondNumber}")]
        public IActionResult Get(string operation, string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                switch (operation)
                {
                    case "sum":
                        var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
                        return Ok(sum.ToString());
                    case "subtract":
                        var subtract = ConvertToDecimal(firstNumber) - ConvertToDecimal(secondNumber);
                        return Ok(subtract.ToString());
                    case "multiply":
                        var multiply = ConvertToDecimal(firstNumber) * ConvertToDecimal(secondNumber);
                        return Ok(multiply.ToString());
                    case "divide":
                        var divide = ConvertToDecimal(firstNumber) / ConvertToDecimal(secondNumber);
                        return Ok(divide.ToString());
                    case "average":
                        var average = (ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber))/2;
                        return Ok(average.ToString());
                    case "square_root":
                        var root = ConvertToDouble(firstNumber) + ConvertToDouble(secondNumber);
                        root = Math.Sqrt(root);
                        return Ok(root.ToString());
                }
            }
            return BadRequest("Invalid Input");
        }

        private bool IsNumeric(string strNumber)
        {
            double number;
            bool isNumber = double.TryParse(
                strNumber,
                System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out number);
            return isNumber;
        }

        private decimal ConvertToDecimal(string strNumber)
        {
            decimal decimalValue;
            if (decimal.TryParse(strNumber, out decimalValue))
            {
                return decimalValue;
            }
            return 0;
        }

        private double ConvertToDouble(string strNumber)
        {
            double doubleValue;
            if (double.TryParse(strNumber, out doubleValue))
            {
                return doubleValue;
            }
            return 0;
        }
    }
}
