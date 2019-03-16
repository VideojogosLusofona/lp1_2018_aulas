using System;

namespace Aula04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração de variáveis
            string frase, carStr;
            char carAEvitar;

            // Solicitar uma frase
            Console.Write("Insere uma frase: ");
            frase = Console.ReadLine();

            // Solicitar um caráter
            Console.Write("Insere um caráter: ");
            carStr = Console.ReadLine();

            // Converter caráter lido de formato string para formato char
            carAEvitar = Convert.ToChar(carStr);
            // Podia também ser carAEvitar = carStr[0];

            // Imprimir frase, exceto o caráter
            foreach (char carAtual in frase)
            {
                // Será o carAtual diferente do carAEvitar?
                if (carAtual != carAEvitar)
                {
                    // Em caso afirmativo, mostrá-lo no ecrã
                    Console.Write(carAtual);
                }
            }

            // Imprimir nova linha
            Console.WriteLine();
        }
    }
}
