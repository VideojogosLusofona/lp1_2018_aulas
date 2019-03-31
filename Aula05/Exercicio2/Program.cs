using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            CountTo10();
            Console.WriteLine();
            CountTo10();
            Console.WriteLine();
            CountToN(3);
            Console.WriteLine();
            CountToN(5);
        }

        static void CountTo10()
        {
            CountToN(10);
        }

        static void CountToN(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }

    }
}
