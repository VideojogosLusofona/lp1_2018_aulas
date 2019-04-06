using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração de variáveis
            int nDados, valorDoDado, total = 0;
            Random gerador;

            // Inicializar gerador de números aleatórios
            gerador = new Random();

            // Pedir número de dados ao utilizador
            Console.Write("Quantos dados queres lançar? ");
            nDados = Convert.ToInt32(Console.ReadLine());

            // Lançar dados e somar valores
            for (int i = 0; i < nDados; i++)
            {
                // Lançar dado atual, obter valor entre 1 e 6
                valorDoDado = gerador.Next(1, 7); // Não é bug, é mesmo 7!

                // Mostrar valor do dado atual (não é pedido explicitamente
                // no enunciado)
                Console.WriteLine($"* Dado {i,4} -> {valorDoDado}");

                // Somar valor do dado atual ao total
                total += valorDoDado;
            }
 
            // Mostrar soma
            Console.WriteLine($"TOTAL = {total}");
        }
    }
}
