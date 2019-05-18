using System;

namespace Exercicio2
{
    public class Player : Agent
    {
        /// <summary>
        /// Creates a new Player.
        /// </summary>
        /// <param name="name">The name of the player.</param>
        public Player(string name) : base(name) { }

        /// <summary>
        /// Moves the player according to player instructions.
        /// </summary>
        /// <returns>
        /// A direction to move, which can be 'N', 'S', 'W' or 'E'.
        /// </returns>
        public override char Move()
        {
            // Direction variable
            char dir;

            // Ask player for direction, don't stop until player inputs valid
            // direction
            do
            {
                // Ask player for direction
                Console.Write("Where do you want to move (NSWE)? ");

                // Get direction as string, convert to uppercase, and get first
                // character in string
                dir = Console.ReadLine().ToUpper()[0];

                // If character exists in the directions string, end cycle
                // Otherwise keep asking in a loop until player gives valid
                // direction
            } while (!directions.Contains(dir));

            // Return direction
            return dir;
        }

        /// <summary>
        /// Override of the ToString() method.
        /// </summary>
        /// <returns>A short description of the Player.</returns>
        public override string ToString() =>
            $"I'm a Player and my name is {Name}";

    }
}
