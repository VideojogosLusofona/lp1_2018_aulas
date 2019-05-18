using System;

namespace Exercicio2
{
    /// <summary>
    /// Class to test our agents.
    /// </summary>
    class Program
    {

        /// <summary>
        /// Program starts here.
        /// </summary>
        /// <param name="args">Not used.</param>
        static void Main(string[] args)
        {
            // Create array of agents with 2 NPCs and 1 Player
            Agent[] agents = new Agent[] {
                new NPC("John"),
                new NPC("Ana"),
                new Player("Ted")
            };

            // Show info about each agent in the array
            foreach (Agent a in agents)
            {
                Console.WriteLine(
                    a.ToString() + " and I'm moving " + a.Move());
            }
        }
    }
}
