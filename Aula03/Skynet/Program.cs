using System;

namespace Aula03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variáveis auxiliares
            string question, response;

            // Colocar questão ao utilizador
            Console.Write("Place your question? ");
            question = Console.ReadLine();

            // Verificar se se trata de uma questão conhecida e determinar uma
            // resposta adequada
            switch (question)
            {
                case "How are you?":
                    response = "I'm fine, thank you";
                    break;
                case "What's your name?":
                    response = "Skynet";
                    break;
                case "What's your mission?":
                    response = "Destroy mankind!";
                    break;
                default:
                    response = "You got me, I'm not THAT smart!";
                    break;
            }

            // Responder adequadamente
            Console.WriteLine(response);
        }
    }
}
