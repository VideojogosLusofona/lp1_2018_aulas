using System;
using System.Collections.Generic;

namespace Exercicio2
{
    /// <summary>
    /// The player listing program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Private enumeration which determines how to order the players.
        /// This enumeration can be private and can exist within Program
        /// because it is only used in the Program class.
        /// </summary>
        private enum OrderingType
        {
            /// <summary>
            /// Order by score.
            /// </summary>
            Score,
            /// <summary>
            /// Order alphabetically.
            /// </summary>
            NameAlpha,
            /// <summary>
            /// Order alphabetically in reverse.
            /// </summary>
            NameReverseAlpha
        };

        /// <summary>
        /// The list of all players.
        /// </summary>
        private List<Player> playerList;

        /// <summary>
        /// How to sort the players (initially we sort by score). We can
        /// initialize this variable here because it's a value type. Reference
        /// types should be initialized in the constructor.
        /// </summary>
        private OrderingType ordering = OrderingType.Score;

        /// <summary>
        /// Object to be passed to the Sort() method to compare players by
        /// name
        /// </summary>
        private IComparer<Player> compareByName;

        /// <summary>
        /// Object to be passed to the Sort() method to compare players by
        /// reverse name
        /// </summary>
        private IComparer<Player> compareByNameReverse;

        /// <summary>
        /// Program begins here.
        /// </summary>
        /// <param name="args">Not used.</param>
        private static void Main(string[] args)
        {
            // Create a new instance of the player listing program
            Program prog = new Program();
            // Start the program instance
            prog.Start();
        }

        /// <summary>
        /// Creates a new instance of the player listing program.
        /// </summary>
        private Program()
        {
            // Instantiate object to compare players by name
            compareByName = new CompareByName(true);

            // Instantiate object to compare players by name in reverse
            compareByNameReverse = new CompareByName(false);

            // Initialize the player list with two players using collection
            // initialization syntax
            playerList = new List<Player>() {
                new Player("Best player ever", 100),
                new Player("An even better player", 500)
            };
        }

        /// <summary>
        /// Start the player listing program instance
        /// </summary>
        private void Start()
        {
            // We keep the user's option here
            string option;

            // Main program loop
            do
            {
                // Show menu and get user option
                ShowMenu();
                option = Console.ReadLine();

                // Determine the option specified by the user and act on it
                switch (option)
                {
                    case "1":
                        // Insert player
                        InsertPlayer();
                        break;
                    case "2":
                        // Re-sort list
                        SortPlayers();
                        // Show all players
                        ListPlayers(playerList);
                        break;
                    case "3":
                        // Re-sort list
                        SortPlayers();
                        // Show players with score greater than
                        ListPlayersWithScoreGreaterThan();
                        break;
                    case "4":
                        // Change ordering type
                        ChangeOrderingType();
                        break;
                    case "5":
                        Console.WriteLine("Bye!");
                        break;
                    default:
                        Console.Error.WriteLine("\n>>> Unknown option! <<<\n");
                        break;
                }

                // Wait for user to press a key...
                Console.Write("\nPress any key to continue...");
                Console.ReadKey(true);
                Console.WriteLine("\n");

                // Loop keeps going until players choses to quit (option 4)
            } while (option != "5");
        }

        /// <summary>
        /// Shows the main menu.
        /// </summary>
        private void ShowMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("----\n");
            Console.WriteLine("1. Insert player");
            Console.WriteLine("2. List all players");
            Console.WriteLine("3. List players with score greater than");
            Console.WriteLine(
                $"4. Change ordering of players (current: {ordering})");
            Console.WriteLine("5. Quit\n");
            Console.Write("Your choice > ");
        }

        /// <summary>
        /// Inserts a new player in the player list.
        /// </summary>
        private void InsertPlayer()
        {
            // Variables
            string name;
            int score;
            Player newPlayer;

            // Ask for player info
            Console.WriteLine("\nInsert player");
            Console.WriteLine("-------------\n");
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Score: ");
            score = Convert.ToInt32(Console.ReadLine());

            // Create new player and add it to list
            newPlayer = new Player(name, score);
            playerList.Add(newPlayer);
        }

        /// <summary>
        /// Show all players in a list of players. This method can be static
        /// because it doesn't depend on anything associated with an instance
        /// of the program. Namely, the list of players is given as a parameter
        /// to this method.
        /// </summary>
        /// <param name="playersToList">
        /// An enumerable object of players to show.
        /// </param>
        private static void ListPlayers(IEnumerable<Player> playersToList)
        {
            Console.WriteLine("\nList of players");
            Console.WriteLine("-------------\n");

            // Show each player in the enumerable object
            foreach (Player p in playersToList)
            {
                Console.WriteLine($" -> {p.Name} with a score of {p.Score}");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Show all players with a score higher than a user-specified value.
        /// </summary>
        private void ListPlayersWithScoreGreaterThan()
        {
            // Minimum score user should have in order to be shown
            int minScore;
            // Enumerable of players with score higher than the minimum score
            IEnumerable<Player> playersWithScoreGreaterThan;

            // Ask the user what is the minimum score
            Console.Write("\nMinimum score player should have? ");
            minScore = Convert.ToInt32(Console.ReadLine());

            // Get players with score higher than the user-specified value
            playersWithScoreGreaterThan =
                GetPlayersWithScoreGreaterThan(minScore);

            // List all players with score higher than the user-specified value
            ListPlayers(playersWithScoreGreaterThan);
        }

        /// <summary>
        /// Ask user to specify ordering type.
        /// </summary>
        private void ChangeOrderingType()
        {
            // Did the user make a valid choice?
            bool validChoice;

            // Ask until players gives valid response
            do
            {
                // User-specified option
                string option;

                // Present options to user and get the user's response
                Console.WriteLine("\nSpecify ordering type:");
                Console.WriteLine(" 0 - By score");
                Console.WriteLine(" 1 - By name (alphabetic ordering)");
                Console.WriteLine(" 2 - By name (reverse alphabetic ordering)");
                Console.Write("> ");
                option = Console.ReadLine();

                // Validate user response
                switch (option)
                {
                    case "0":
                        // Valid response, select order by score
                        ordering = OrderingType.Score;
                        validChoice = true;
                        break;
                    case "1":
                        // Valid response, select order by name
                        ordering = OrderingType.NameAlpha;
                        validChoice = true;
                        break;
                    case "2":
                        // Valid response, select order by name (reverse)
                        ordering = OrderingType.NameReverseAlpha;
                        validChoice = true;
                        break;
                    default:
                        // Invalid response, warn user
                        Console.WriteLine(
                            "\nInvalid choice! Press a key to chose again...");
                        Console.ReadKey();
                        validChoice = false;
                        break;
                }
            }
            while (!validChoice); // Loop until user gives valid response
        }

        /// <summary>
        /// Sort player list according to the currently specified ordering
        /// criteria.
        /// </summary>
        private void SortPlayers()
        {
            // What is the currently specified ordering criteria?
            switch (ordering)
            {
                case OrderingType.Score:
                    // Sort by score (default sort)
                    playerList.Sort();
                    break;
                case OrderingType.NameAlpha:
                    // Sort by name
                    playerList.Sort(compareByName);
                    break;
                case OrderingType.NameReverseAlpha:
                    // Sort by name, in reverse
                    playerList.Sort(compareByNameReverse);
                    break;
            }
        }

        /// <summary>
        /// Get players with a score higher than a given value.
        /// </summary>
        /// <param name="minScore">Minimum score players should have.</param>
        /// <returns>
        /// An enumerable of players with a score higher than the given value.
        /// </returns>
        private IEnumerable<Player> GetPlayersWithScoreGreaterThan(int minScore)
        {
            // Cycle all players in the original player list
            foreach (Player p in playerList)
            {
                // If the current player has a score higher than the
                // given value....
                if (p.Score > minScore)
                {
                    // ...return him as a member of the player enumerable
                    yield return p;
                }
            }
        }
    }
}
