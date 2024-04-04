using System;
using System.Collections.Generic;

namespace GameManager
{
    class Program
    {
        static Dictionary<string, List<string>> gameGenres = new Dictionary<string, List<string>>();

        static void Main(string[] args)
        {
            bool endApp = false;

            while (!endApp)
            {
                Console.WriteLine("\nGame Manager\n");
                Console.WriteLine("1. Add a game to a genre");
                Console.WriteLine("2. Delete a game from a genre");
                Console.WriteLine("3. Sort games by genre");
                Console.WriteLine("4. List all games");
                Console.WriteLine("5. Exit");
                Console.Write("\nEnter the number of the operation you want to perform: ");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        AddGame();
                        break;
                    case "2":
                        DeleteGame();
                        break;
                    case "3":
                        SortGamesByGenre();
                        break;
                    case "4":
                        ListAllGames();
                        break;
                    case "5":
                        endApp = true;
                        break;
                    default:
                        Console.WriteLine("\nInvalid input. Please enter a valid number.\n");
                        break;
                }
            }
        }

        static void AddGame()
        {
            Console.Write("\nEnter the name of the game: ");
            string name = Console.ReadLine();

            Console.Write("\nEnter the genre of the game: ");
            string genre = Console.ReadLine();

            if (!gameGenres.ContainsKey(genre))
            {
                gameGenres.Add(genre, new List<string>());
            }

            gameGenres[genre].Add(name);
            Console.WriteLine("\nGame added successfully.\n");
        }

        static void DeleteGame()
        {
            Console.Write("\nEnter the name of the game to delete: ");
            string gameName = Console.ReadLine();

            Console.Write("\nEnter the genre of the game: ");
            string genre = Console.ReadLine();

            if (gameGenres.ContainsKey(genre) && gameGenres[genre].Contains(gameName))
            {
                gameGenres[genre].Remove(gameName);
                Console.WriteLine("\nGame deleted successfully.\n");
            }
            else
            {
                Console.WriteLine("\nThe specified game does not exist in the specified genre.\n");
            }
        }

        static void SortGamesByGenre()
        {
            foreach (KeyValuePair<string, List<string>> entry in gameGenres)
            {
                Console.WriteLine($"\nGenre: {entry.Key}");
                foreach (string game in entry.Value)
                {
                    Console.WriteLine($"- {game}");
                }
            }
            Console.WriteLine();
        }

        static void ListAllGames()
        {
            List<string> allGames = new List<string>();

            foreach (KeyValuePair<string, List<string>> entry in gameGenres)
            {
                allGames.AddRange(entry.Value);
            }

            Console.WriteLine("\nGames:");
            foreach (string game in allGames)
            {
                Console.WriteLine($"- {game}");
            }
            Console.WriteLine();
        }
    }
}

