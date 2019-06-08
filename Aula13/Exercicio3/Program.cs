using System;
using System.Collections;

namespace Exercicio3
{
    /// <summary>
    /// Solution for exercise 3, lesson 13.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// As always, program starts here.
        /// </summary>
        private static void Main()
        {
            // Array of stuff of different types (could also a List<object>,
            // an ArrayList, Queue, etc)
            object[] myStuff = { "Hello", 3, 4, 4.5, 32.3f, -12f, "Goodbye",
                "LP1", 14L, 911L, 43, 19UL, -120, 14L, 15f, 19.4f, 14.5, 'a' };

            // Show how many of each type
            Console.WriteLine("How many strings? -> {0}",
                HowManyOfThisType<string>(myStuff));
            Console.WriteLine("How many ints? -> {0}",
                HowManyOfThisType<int>(myStuff));
            Console.WriteLine("How many floats? -> {0}",
                HowManyOfThisType<float>(myStuff));
            Console.WriteLine("How many doubles? -> {0}",
                HowManyOfThisType<double>(myStuff));
            Console.WriteLine("How many longs? -> {0}",
                HowManyOfThisType<long>(myStuff));
            Console.WriteLine("How many chars? -> {0}",
                HowManyOfThisType<char>(myStuff));
            Console.WriteLine("How many unsigned longs? -> {0}",
                HowManyOfThisType<ulong>(myStuff));
            Console.WriteLine("How many bytes? -> {0}",
                HowManyOfThisType<byte>(myStuff));

            // Show total quantity of stuff
            Console.WriteLine("\nHow many items in total? ->  {0}",
                myStuff.Length);
        }

        /// <summary>
        /// Returns how much items of a given type there are in the given
        /// enumerable.
        /// </summary>
        /// <param name="stuff">Enumerable containing stuff.</param>
        /// <typeparam name="T">
        /// Type to check for in the enumerable.
        /// </typeparam>
        /// <returns>
        /// Number of items of the given type in the enumerable.
        /// </returns>
        private static int HowManyOfThisType<T>(IEnumerable stuff)
        {
            int counter = 0;
            foreach (object o in stuff)
            {
                if (o is T) counter++;
            }
            return counter;
        }
    }
}
