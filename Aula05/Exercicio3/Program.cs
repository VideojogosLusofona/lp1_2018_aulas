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
        }

        /// <summary>
        /// Print numbers from one to ten.
        /// </summary>
        static void CountTo10()
        {
            CountToN(10);
        }

        /// <summary>
        /// Print numbers from one to a given value.
        /// </summary>
        /// <param name="n">Maximum value of printed numbers.</param>
        static void CountToN(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
