using System;
using System.Collections.Generic;

namespace SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            var parkingRegistrations = new Dictionary<string, string>();

            string input = Console.ReadLine();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string command = input.Split()[0];
                
                if (command == "register")
                {
                    string user = input.Split()[1];
                    string licensePlate = input.Split()[2];

                    if (parkingRegistrations.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {parkingRegistrations[user]}");
                    }
                    else
                    {
                        parkingRegistrations.Add(user, licensePlate);
                        Console.WriteLine($"{user} registered {licensePlate} successfully");
                    }
                }
                else if (command == "unregister")
                {
                    string user = input.Split()[1];

                    if (!parkingRegistrations.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: user {user} not found");
                    }
                    else
                    {
                        parkingRegistrations.Remove(user);
                        Console.WriteLine($"{user} unregistered successfully");
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var user in parkingRegistrations)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
