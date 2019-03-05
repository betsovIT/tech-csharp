using System;

namespace Dungeonest_Dark
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int coins = 0;

            string[] dungeon = Console.ReadLine().Split('|');

            for (int i = 0; i < dungeon.Length; i++)
            {
                string[] room = dungeon[i].Split();

                if (room[0] == "potion")
                {
                    if (health + int.Parse(room[1]) > 100)
                    {
                        Console.WriteLine($"You healed for {100 - health} hp.");
                        health = 100;                        
                    }
                    else
                    {
                        Console.WriteLine($"You healed for {int.Parse(room[1])} hp.");
                        health += int.Parse(room[1]);
                    }
                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if (room[0] == "chest")
                {
                    Console.WriteLine($"You found {room[1]} coins.");
                    coins += int.Parse(room[1]);
                }
                else if (room[0] != "potion" && room[0] != "chest")
                {
                    if (health - int.Parse(room[1]) > 0)
                    {
                        Console.WriteLine($"You slayed {room[0]}.");
                        health -= int.Parse(room[1]);
                    }
                    else if (health - int.Parse(room[1]) <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {room[0]}.");
                        Console.WriteLine($"Best room: {i+1}");
                        return;
                    }
                }
            }
            Console.WriteLine($"You've made it!");
            Console.WriteLine($"Coins: {coins}");
            Console.WriteLine($"Health: {health}");
        }
    }
}
