using Microsoft.AspNetCore.Mvc;

namespace Calculator.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController
    {
        private static readonly string[] Operations = new[]
        {
            "Somar", "Multiplicar", "Subtrair", "Dividir", "Potencia"
        };


        [HttpPost("Operacao")]
        public string Calculate(double numberOne, double numberTwo, string operation)
        {
            var calculator = new Calculator()
            {
                NumberOne = numberOne,
                NumberTwo = numberTwo,
            };

            switch(operation.ToLower())
            {
                case "somar": return $"Resultado: {calculator.Somar()}";
                case "multiplicar": return $"Resultado: {calculator.Multiplicar()}";
                case "subtrair": return $"Resultado: {calculator.Subtrair()}";
                case "dividir": return $"Resultado: {calculator.Dividir()}";
                case "potencia": return $"Resultado: {calculator.Potencia()}";
                default: return "Operação invalida.";
            }
        }

        [HttpGet("ListarOperacoes")]
        public IEnumerable<object> ListOperations()
        {
            return Enumerable.Range(0, 5).Select(i => new
            {
                Operation = Operations[i]
            }).ToArray();
        }

        [HttpPost("Porcentagem")]
        public string Porcentagem(double valor, double porcentagem)
        {
            var calculator = new Calculator()
            {
                NumberOne = valor,
                NumberTwo = porcentagem,
            };

            return $"{porcentagem}% de {valor} é igual a: {calculator.Porcentagem()}";
        }
    }

}
