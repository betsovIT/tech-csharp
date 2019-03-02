using System;

namespace Bread_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = 100;
            int coins = 100;
            string[] events = Console.ReadLine().Split('|');

            for (int i = 0; i < events.Length; i++)
            {
                string[] activity = events[i].Split('-');

                if (activity[0] == "rest")
                {
                    int energyToGain = int.Parse(activity[1]);

                    if (energy + energyToGain > 100)
                    {
                        energy = 100;
                        Console.WriteLine($"You gained {100 - energy} energy.");
                        Console.WriteLine($"Current energy: {energy}.");
                    }
                    else
                    {
                        energy += energyToGain;
                        Console.WriteLine($"You gained {energyToGain} energy.");
                        Console.WriteLine($"Current energy: {energy}.");
                    }
                }

                if (activity[0] == "order")
                {
                    if (energy >= 30)
                    {
                        energy -= 30;
                        coins += int.Parse(activity[1]);
                        Console.WriteLine($"You earned {activity[1]} coins.");
                    }
                    else
                    {
                        Console.WriteLine("You had to rest!");
                        int energyToGain = 50;

                        if (energy + energyToGain > 100)
                        {
                            energy = 100;
                        }
                        else
                        {
                            energy += energyToGain;
                        }

                    }
                }

                if (activity[0] != "rest" && activity[0] != "order")
                {
                    if (coins > int.Parse(activity[1]))
                    {
                        coins -= int.Parse(activity[1]);
                        Console.WriteLine($"You bought {activity[0]}.");
                    }
                    else
                    {
                        Console.WriteLine($"Closed! Cannot afford {activity[0]}.");
                        break;
                    }
                }

                if (i == events.Length - 1)
                {
                    Console.WriteLine("Day completed!");
                    Console.WriteLine($"Coins: {coins}");
                    Console.WriteLine($"Energy: {energy}");
                }
            }
        }
    }
}
