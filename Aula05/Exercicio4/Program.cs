using System;

namespace Exercicio1
{
    /// <summary>
    /// This class contains the Main method and prints some values.
    /// </summary>
    class Program
    {
        /// <summary>
        /// The program starts here.
        /// </summary>
        /// <param name="args">Command-line arguments (unused).</param>
        static void Main(string[] args)
        {
            CountTo10();
            Console.WriteLine();
            CountTo10();
            Console.WriteLine();
            CountToN(3);
            Console.WriteLine();
            CountToN(5);
            Console.WriteLine();
            CountToN(8, 12);
        }

        /// <summary>
        /// Print numbers from one to ten.
        /// </summary>
        static void CountTo10()
        {
            CountToN(10);
        }

        /// <summary>
        /// Print numbers from one to <paramref name="n"/>.
        /// </summary>
        /// <param name="n">Last number to print.</param>
        static void CountToN(int n)
        {
            CountToN(1, n);
        }

        /// <summary>
        /// Print numbers from <paramref name="n1"/> to <paramref name="n2"/>.
        /// </summary>
        /// <param name="n1">First number to print.</param>
        /// <param name="n2">Last number to print.</param>
        static void CountToN(int n1, int n2)
        {
            for (int i = n1; i <= n2; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
