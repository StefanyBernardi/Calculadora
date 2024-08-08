using System;
using System.Numerics;
using Xunit;

namespace Calculadora.Tests
{
    public class CalculadoraTests
    {
        private readonly Calculadora _calculadora;

        public CalculadoraTests()
        {
            _calculadora = new Calculadora();
        }

        [Fact]
        public void Soma_DeveRetornarResultadoCorreto()
        {
            var operacao = new Operacoes { valorA = 5, valorB = 10, operador = '+' };
            var resultado = _calculadora.calcular(operacao);
            Assert.Equal(new BigInteger(15), resultado.resultado);
        }

        [Fact]
        public void Subtracao_DeveRetornarResultadoCorreto()
        {
            var operacao = new Operacoes { valorA = 10, valorB = 5, operador = '-' };
            var resultado = _calculadora.calcular(operacao);
            Assert.Equal(new BigInteger(5), resultado.resultado);
        }

        [Fact]
        public void Multiplicacao_DeveRetornarResultadoCorreto()
        {
            var operacao = new Operacoes { valorA = 5, valorB = 10, operador = '*' };
            var resultado = _calculadora.calcular(operacao);
            Assert.Equal(new BigInteger(50), resultado.resultado);
        }

        [Fact]
        public void Divisao_DeveRetornarResultadoCorreto()
        {
            var operacao = new Operacoes { valorA = 10, valorB = 2, operador = '/' };
            var resultado = _calculadora.calcular(operacao);
            Assert.Equal(new BigInteger(5), resultado.resultado);
        }

        [Fact]
        public void Divisao_PorZero_DeveLancarExcecao()
        {
            var operacao = new Operacoes { valorA = 10, valorB = 0, operador = '/' };

            var stringWriter = new System.IO.StringWriter();
            Console.SetOut(stringWriter);

            var resultado = _calculadora.calcular(operacao);

            Assert.Equal(BigInteger.Zero, resultado.resultado);
            Assert.Contains("Não é possível realizar uma divisão pelo número zero", stringWriter.ToString());
        }
    }
}