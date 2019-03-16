using System;

namespace Aula03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração de variáveis
            int numLinhas, numColunas;
            string aux;
            float[,] matriz;
            float somaDasMedias = 0;

            // Pedir nº de linhas e converter para inteiro
            Console.Write("Insira nº de linhas da matriz: ");
            aux = Console.ReadLine();
            numLinhas = Convert.ToInt32(aux);

            // Pedir nº de colunas e converter para inteiro
            Console.Write("Insira nº de colunas da matriz: ");
            aux = Console.ReadLine();
            numColunas = Convert.ToInt32(aux);

            // Inicializar a matriz (array bidimensional)
            matriz = new float[numLinhas, numColunas];

            // Pedir valores da matriz
            for (int i = 0; i < numLinhas; i++) // Percorrer linhas
            {
                for (int j = 0; j < numColunas; j++) // Percorrer colunas
                {
                    // Solicitar valor para linha i e coluna j
                    Console.Write($"Insere valor em ({i},{j}): ");
                    aux = Console.ReadLine();

                    // Converter valor pedido para formato float (Single)
                    matriz[i, j] = Convert.ToSingle(aux);
                }
            }

            // Mostrar matriz e médias de cada linha
            Console.WriteLine("\nMatriz inserida e respetivas médias:");

            for (int i = 0; i < numLinhas; i++) // Percorrer linhas
            {
                // Declaração e inicialização da variável onde vamos guardar a
                // soma dos valores na linha atual
                float somaDaLinha = 0;
                float mediaDaLinha;

                // Mostrar caráter de início de linha
                Console.Write("| ");

                for (int j = 0; j < numColunas; j++) // Percorrer colunas
                {
                    // Mostrar o valor na linha/coluna atuais
                    Console.Write("{0,10:f2}", matriz[i, j]);

                    // Adicionar valor atual à soma da linha atual
                    somaDaLinha += matriz[i, j];
                }

                // Mostrar caráter de fim de linha de matriz
                Console.Write(" | ");

                // Calcular media da linha
                mediaDaLinha = somaDaLinha / numColunas;

                // Mostrar a média da linha
                Console.WriteLine(
                    $"-> Média = {mediaDaLinha,10:f3}");

                // Adicionar a média da linha à soma das médias
                somaDasMedias += mediaDaLinha;
            }

            // Mostrar soma das médias
            Console.WriteLine($"\nSoma das médias: {somaDasMedias:f3}");

        }
    }
}
