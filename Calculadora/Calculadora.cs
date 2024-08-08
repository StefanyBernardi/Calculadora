using System;
using System.Collections;
using System.Numerics;

namespace Calculadora
{
    public class Calculadora
    {
        
        public Operacoes calcular(Operacoes operacao)
        {
           
            switch(operacao.operador)
            {
                case '+': operacao.resultado= soma(operacao);break;
                case '-': operacao.resultado = subtracao(operacao);break;
                case '*': operacao.resultado = multiplicacao(operacao);break;
                case '/': operacao.resultado = divisao(operacao); break;
                default: operacao.resultado = 0; break;
            }
            
            return operacao;
        }

       

        public BigInteger soma(Operacoes operacao)
        {
            BigInteger a = operacao.valorA;
            BigInteger b = operacao.valorB;
           
            return a + b;
        }
        public BigInteger subtracao(Operacoes operacao)
        {
            return operacao.valorA - operacao.valorB;
        }
        public BigInteger multiplicacao(Operacoes operacao)
        {
            return operacao.valorA * operacao.valorB;
        }
        public BigInteger divisao(Operacoes operacao)
        {
            BigInteger resultado = 0;

            try
            {
                if (operacao.valorB != 0)
                {
                    resultado = operacao.valorA / operacao.valorB;
                }
                else
                    throw new Exception("Não é possível realizar uma divisão pelo número zero");

                return resultado;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return resultado;
            }
        }
       
    }
}
