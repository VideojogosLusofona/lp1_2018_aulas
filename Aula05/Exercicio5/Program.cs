using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração de variáveis
            string nStr;
            uint n, fib;

            // Pedir n ao utilizador
            Console.Write("Indica n, em que n é o n-ésimo número "
                + "da sequência de Fibonacci: ");
            nStr = Console.ReadLine();
            n = Convert.ToUInt32(nStr);

            // Obter n-ésimo número da sequência de Fibonacci
            fib = Fibonacci(n);

            // Mostrar número
            Console.WriteLine($"O {n}-ésimo número de Fibonacci é {fib}.");
        }

        static uint Fibonacci(uint n)
        {
            // Declaração de variáveis, neste caso apenas o número de Fibonacci
            // a devolver
            uint fib;

            // Verificar se estamos no caso base ou no caso normal
            if (n <= 2)
            {
                // Caso base: dois primeiros números de Fibonacci são 1
                fib = 1;
            }
            else
            {
                // Caso normal (recursivo): número de Fibonacci é igual à soma
                // dos dois números de Fibonacci anteriores
                fib = Fibonacci(n - 2) + Fibonacci(n - 1);
            }

            // Devolver n-ésimo número de Fibonacci
            return fib;
        }
    }
}
