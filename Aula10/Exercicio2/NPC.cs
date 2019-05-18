using System;

namespace Exercicio2
{
    /// <summary>
    /// Represents an NPC, extends Agent.
    /// </summary>
    public class NPC : Agent
    {
        /// <summary>
        /// A random number generator, used for getting a random movement
        /// direction.
        /// </summary>
        private Random rnd;

        /// <summary>
        /// Creates a new NPC.
        /// </summary>
        /// <param name="name">The name of the NPC.</param>
        public NPC(string name) : base(name)
        {
            // Initialize the random number generator.
            rnd = new Random();
        }

        /// <summary>
        /// Moves the NPC randomly.
        /// </summary>
        /// <returns>
        /// A random direction, which can be 'N', 'S', 'W' or 'E'.
        /// </returns>
        public override char Move()
        {
            // Get a random number between 0 and 3.
            int i = rnd.Next(4);
            // Return a character in a random position of the string "NSWE".
            // Note that the directions constant is defined in the base class.
            return directions[i];
        }

        /// <summary>
        /// Override of the ToString() method.
        /// </summary>
        /// <returns>A short description of the NPC.</returns>
        public override string ToString() =>
            $"I'm an NPC and my name is {Name}";
    }
}
