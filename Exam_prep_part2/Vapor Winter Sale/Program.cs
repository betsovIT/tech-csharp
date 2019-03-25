using System;
using System.Collections.Generic;
using System.Linq;

namespace Vapor_Winter_Sale
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] gamesInput = Console.ReadLine().Split(", ");
            var gameCatalogue = new Dictionary<string, Game>();

            for (int i = 0; i < gamesInput.Length; i++)
            {
                string game = gamesInput[i];

                if (game.Contains('-'))
                {
                    int specCharIndex = game.IndexOf('-');
                    string gameName = game.Substring(0, specCharIndex);
                    double gamePrice = double.Parse(game.Substring(specCharIndex + 1, game.Length - 1 - specCharIndex));

                    Game gameAsObject = new Game { Price = gamePrice };

                    if (!gameCatalogue.ContainsKey(gameName))
                    {
                        gameCatalogue.Add(gameName, gameAsObject);
                    }
                }
                else if (game.Contains(':'))
                {
                    int specCharIndex = game.IndexOf(':');
                    string gameName = game.Substring(0, specCharIndex);
                    string dlcName = game.Substring(specCharIndex + 1, game.Length - 1 - specCharIndex);

                    if (gameCatalogue.ContainsKey(gameName))
                    {
                        gameCatalogue[gameName].DLC = dlcName;
                        gameCatalogue[gameName].Price *= 1.2;
                    }
                }
            }

            foreach (var game in gameCatalogue)
            {
                if (game.Value.DLC != null)
                {
                    game.Value.Price /= 2;
                }
                else
                {
                    game.Value.Price *= 0.8;
                }
            }

            foreach (var game in gameCatalogue.Where(n => n.Value.DLC != null).OrderBy(n => n.Value.Price))
            {
                Console.WriteLine($"{game.Key} - {game.Value.DLC} - {game.Value.Price:F2}");
            }
            foreach (var game in gameCatalogue.Where(n => n.Value.DLC == null).OrderByDescending(n => n.Value.Price))
            {
                Console.WriteLine($"{game.Key} - {game.Value.Price:F2}");
            }
        }
    }
    class Game
    {
        public double Price { get; set; }
        public string DLC { get; set; }
    }
}
