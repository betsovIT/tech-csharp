using System;
using System.Collections.Generic;
using System.Linq;

namespace MOBA_Challenger
{
    class Program
    {
        static void Main(string[] args)
        {
            var playerPool = new Dictionary<string, Dictionary<string, int>>();
            string[] separators = { " vs ", " -> " };

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Season end")
                {
                    break;
                }
                string[] command = input.Split(separators, StringSplitOptions.None);

                if (command.Length == 3)
                {
                    string player = command[0];
                    string position = command[1];
                    int skill = int.Parse(command[2]);
                    if (!playerPool.ContainsKey(player))
                    {
                        playerPool.Add(player, new Dictionary<string, int>());
                        playerPool[player].Add(position, skill);
                    }
                    else
                    {
                        if (!playerPool[player].ContainsKey(position))
                        {
                            playerPool[player].Add(position, skill);
                        }
                        else
                        {
                            if (playerPool[player][position] < skill)
                            {
                                playerPool[player][position] = skill;
                            }
                        }
                    }
                }
                else if (command.Length == 2)
                {
                    string player1 = command[0];
                    string player2 = command[1];

                    if (playerPool.ContainsKey(player1) && playerPool.ContainsKey(player2))
                    {
                        bool endCycles = false;
                        string playerToRemove = string.Empty;

                        foreach (var position in playerPool[player1])
                        {
                            foreach (var corespongdingPosition in playerPool[player2])
                            {
                                if (position.Key == corespongdingPosition.Key)
                                {
                                    endCycles = true;
                                    if (playerPool[player1][position.Key] > playerPool[player2][corespongdingPosition.Key])
                                    {
                                        playerToRemove = player2;
                                    }
                                    else if (playerPool[player1][position.Key] < playerPool[player2][corespongdingPosition.Key])
                                    {
                                        playerToRemove = player1;
                                    }
                                    break;
                                }
                            }
                            if (endCycles)
                            {
                                break;
                            }
                        }

                        if (playerToRemove != string.Empty)
                        {
                            playerPool.Remove(playerToRemove);
                        }
                    }
                }

            }

            var orderedPlayerPool = playerPool.OrderByDescending(n => n.Value.Values.Sum()).ThenBy(n => n.Key);

            foreach (var player in orderedPlayerPool)
            {
                Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");
                foreach (var position in player.Value.OrderByDescending(n => n.Value).ThenBy(n => n.Key))
                {
                    Console.WriteLine($"- {position.Key} <::> {position.Value}");
                }
            }

        }
    }
}
