using System;
using System.Linq;

namespace Present_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] houses = Console.ReadLine().Split('@').Select(int.Parse).ToArray();

            for (int i = 0; i < houses.Length; i++)
            {
                houses[i] = houses[i] / 2;
            }

            string input = Console.ReadLine();

            int jump = 0;
            int lastPositionIndex = 0;

            while (input != "Merry Xmas!")
            {

                string[] command = input.Split();

                jump += int.Parse(command[1]);

                if (jump < houses.Length)
                {
                    if (houses[jump] == 0)
                    {
                        Console.WriteLine($"House {jump} will have a Merry Christmas.");
                    }
                    else if (houses[jump] > 0)
                    {
                        houses[jump]--;
                    }
                }
                else
                {
                    while (jump >= houses.Length)
                    {
                        jump -= houses.Length;
                    }
                    if (houses[jump] == 0)
                    {
                        Console.WriteLine($"House {jump} will have a Merry Christmas.");
                    }
                    else if (houses[jump] > 0)
                    {
                        houses[jump]--;
                    }
                }
                
                lastPositionIndex = jump;
                input = Console.ReadLine();
            }

            bool successful = true;
            int housesFailed = 0;
            for (int i = 0; i < houses.Length; i++)
            {
                if (houses[i] > 0)
                {
                    successful = false;
                    housesFailed++;
                }
            }

            Console.WriteLine($"Santa's last position was {lastPositionIndex}.");
            if (successful)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Santa has failed {housesFailed} houses.");
            }
        }
    }
}
