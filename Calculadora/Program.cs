using System;
using System.Collections;
using System.Collections.Generic;

namespace Calculadora
{
    class Program
    {
       public static void Main(string[] args)
        {
            Queue<Operacoes> filaOperacoes = new Queue<Operacoes>();
            filaOperacoes.Enqueue(new Operacoes { valorA = 2, valorB = 3, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 14, valorB = 8, operador = '-' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 5, valorB = 6, operador = '*' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 2147483647, valorB = 2, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 17, valorB = 0, operador = '/' }); //Implemente o calculo de divisao

            Calculadora calculadora = new Calculadora();
            Stack myStack = new Stack();



            while (filaOperacoes.Count > 0)
            {
                Operacoes operacao = filaOperacoes.Peek();
                calculadora.calcular(operacao);
                Console.WriteLine($"Operacao a ser realizada: {operacao.valorA}{operacao}{operacao.valorB}");
                myStack.Push(operacao.resultado);
                //Console.WriteLine("{0} {1} {2} = {3}", operacao.valorA,operacao.operador,operacao.valorB, operacao.resultado);
                filaOperacoes.Dequeue();
            }

            foreach (var item in myStack)
            {
                Console.WriteLine($"Os resultados das operacoes são: {item}");
            }
        }
    }
}
