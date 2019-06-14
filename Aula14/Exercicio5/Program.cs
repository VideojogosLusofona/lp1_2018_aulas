using System;
using System.IO;
using System.Collections.Generic;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variáveis
            string str;
            Stack<string> stack = new Stack<string>();
            const string filename = "LP1.txt";

            // Pedir strings ao user e colocar na stack
            Console.WriteLine("Insira strings + ENTER, só ENTER para sair.");
            do
            {
                str = Console.ReadLine();
                stack.Push(str);
            }
            while (str != "");

            // Gravar strings na stack num ficheiro
            File.WriteAllLines(filename, stack);
        }
    }
}
