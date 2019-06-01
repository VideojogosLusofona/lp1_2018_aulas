using System;
using System.Collections.Generic;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a set and put three players in it, two of which have
            // equal fields
            ISet<Player> setOfPlayers = new HashSet<Player>() {
                new Player() { Type = PlayerType.Tank,  Name = "Ana" },
                new Player() { Type = PlayerType.Slayer,  Name = "Paulo" },
                new Player() { Type = PlayerType.Tank,  Name = "Ana" },
            };

            // Show stuff in set
            foreach (Player p in setOfPlayers)
                Console.WriteLine($"{p.Name} is a {p.Type}");

            // Stuff for you (the student) to try:
            // 1 - Remove the overrides for GetHashCode() and Equals() in the
            //     the Player class. What changes when we list the players in
            //     the set?
            // 2 - Continuing without the overrides, convert the Player class
            //     into a struct. What changes when we list the players in the
            //     set?
        }
    }
}
