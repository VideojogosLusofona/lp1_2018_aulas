using System;

namespace Exercicio2
{
    /// <summary>
    /// A player.
    /// </summary>
    public class Player : IComparable<Player>
    {
        /// <summary>
        /// The name of the player.
        /// </summary>
        /// <value>A string representing the name of the player.</value>
        public string Name { get; }

        /// <summary>
        /// The score.
        /// </summary>
        /// <value>An integer representing the score of the player.</value>
        public int Score { get; set; }

        /// <summary>
        /// Creates a new player.
        /// </summary>
        /// <param name="name">The player name.</param>
        /// <param name="score">The initial player score.</param>
        public Player(string name, int score)
        {
            Name = name;
            Score = score;
        }

        /// <summary>
        /// Compares the current player with another player according to the
        /// rules of the IComparable interface.
        /// </summary>
        /// <param name="other">
        /// The other player which will be compared to the current player.
        /// </param>
        /// <returns>
        /// A negative number if current player comes before the other player.
        /// Zero if both players are to appear in a similar order.
        /// A positive number if current player is to appear after the other
        /// player.
        /// </returns>
        public int CompareTo(Player other)
        {
            if (other == null) return -1;
            return other.Score - Score;
        }
    }
}
