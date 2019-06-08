using System;
using System.Collections.Generic;

namespace Exercicio4
{
    /// <summary>
    /// Solution for exercise 4, lesson 13.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// As always, program starts here.
        /// </summary>
        private static void Main()
        {
            // A list of ints
            List<int> listOfInts = new List<int>()
                { 4, 5, -100, 14, 1, 0, -4, 39, 12, 6, -4 };

            // A set of doubles
            HashSet<double> setOfDoubles = new HashSet<double>()
                { 1.2, -19.4, 0.11, 0.16, 10.0, -500.1, 19.5, 1.23, 0.0015};

            // Show ints that come before one
            Console.Write("Ints that come before 1       : ");
            foreach (int i in ThoseWhoComeBefore<int>(listOfInts, 1))
            {
                // Make sure the number occupies 9 columns in the terminal
                Console.Write($"{i,9}");
            }

            // Show doubles that come before 0.01
            Console.Write("\nDoubles that come before 0.01 : ");
            foreach (double d in ThoseWhoComeBefore<double>(setOfDoubles, 0.01))
            {
                // Make sure the number occupies 9 columns in the terminal
                Console.Write($"{d,9}");
            }

            // Newline at end of program
            Console.WriteLine();
        }

        /// <summary>
        /// Returns items in an enumerable that come before another item.
        /// </summary>
        /// <param name="items">Enumerable containing items.</param>
        /// <param name="anItem">
        /// The item which comes after the items returned by this method.
        /// </param>
        /// <typeparam name="T">
        /// Type of items in the enumerable.static Must be a value type and
        /// implement the generic IComparable.</typeparam>
        /// <returns>Items that come before another item.</returns>
        private static IEnumerable<T> ThoseWhoComeBefore<T>(
            IEnumerable<T> items, T anItem)
            where T : struct, IComparable<T>
        {
            foreach (T currentItem in items)
            {
                if (currentItem.CompareTo(anItem) < 0)
                {
                    yield return currentItem;
                }
            }
        }
    }
}
