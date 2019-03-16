using System;

namespace Aula03
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            // Testar incremento como sufixo
            a = 2;
            b = 4;
            c = a++ + b++;
            Console.WriteLine($"a={a}, b={b}, c={c}");

            // Testar decremento como prefixo
            a = 2;
            b = 4;
            c = --a + --b;
            Console.WriteLine($"a={a}, b={b}, c={c}");

        }
    }
}
