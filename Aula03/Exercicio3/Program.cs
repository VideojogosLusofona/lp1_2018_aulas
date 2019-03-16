using System;

namespace Aula03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração de variáveis
            string nLinhasStr;
            int nLinhas;

            // Solicitar nº de linhas ao utilizador
            Console.Write("Insira número de linhas: ");
            nLinhasStr = Console.ReadLine();

            // Converter nº de linhas em formato string para formato inteiro
            nLinhas = Convert.ToInt32(nLinhasStr);

            // Ciclo de impressão da pirâmide, uma linha de cada vez
            for (int i = 0; i < nLinhas; i++)
            {
                // Declaração de variáveis locais ao for
                int numEsps, numAsts;

                // Determinar quantos espaços devem ser impressos
                numEsps = nLinhas - i - 1;

                // Determinar quantos asteriscos devem ser impressos
                numAsts = i * 2 + 1;

                // Imprimir espaços da linha atual
                for (int j = 0; j < numEsps; j++)
                {
                    Console.Write(" ");
                }

                // Imprimir asteriscos da linha atual
                for (int j = 0; j < numAsts; j++)
                {
                    Console.Write("*");
                }

                // Imprimir nova linha
                Console.WriteLine();
            }
        }
    }
}
