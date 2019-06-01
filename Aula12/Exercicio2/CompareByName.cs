using System.Collections.Generic;

namespace Exercicio2
{
    /// <summary>
    /// Compares players by name according to the IComparer interface.
    /// </summary>
    /// <typeparam name="Player">Type which will be compared.</typeparam>
    public class CompareByName : IComparer<Player>
    {
        // True for ascending order, false otherwise
        private bool ord;

        /// <summary>
        /// Creates a new instance of CompareByName.
        /// </summary>
        /// <param name="ord">
        /// True for ascending order, false otherwise.
        /// </param>
        public CompareByName(bool ord)
        {
            this.ord = ord;
        }

        /// <summary>
        /// Compares two players by name.
        /// </summary>
        /// <param name="x">The first player.</param>
        /// <param name="y">The second player.</param>
        /// <returns>
        /// A negative number if the first player's name comes before the
        /// second player's name.
        /// Zero if both players have the same name.
        /// A positive number if first player's name is to appear after the
        /// second player's name.
        /// </returns>
        public int Compare(Player x, Player y)
        {
            if (x == y) return 0;
            if (x == null) return 1;
            if (y == null) return -1;
            return ord ? x.Name.CompareTo(y.Name) : y.Name.CompareTo(x.Name);
        }
    }
}
