using System;
using System.Collections.Generic;
using System.Linq;

namespace Iron_Girder
{
    class Program
    {
        static void Main(string[] args)
        {
            var towns = new Dictionary<string, int[]>();
            string[] separators = { ":", "->" };

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Slide rule")
                {
                    break;
                }

                string town = command.Split(separators, StringSplitOptions.None)[0];
                string timeOrAmbush = command.Split(separators, StringSplitOptions.None)[1];
                int passengers = int.Parse(command.Split(separators, StringSplitOptions.None)[2]);

                if (timeOrAmbush != "ambush")
                {
                    int time = int.Parse(timeOrAmbush);

                    if (!towns.ContainsKey(town))
                    {
                        towns.Add(town, new int[] { 0, 0 });
                    }

                    if (time < towns[town][0] || towns[town][0] == 0)
                    {
                        towns[town][0] = time;
                    }

                    towns[town][1] += passengers;
                }
                else if (timeOrAmbush == "ambush")
                {
                    if (!towns.ContainsKey(town))
                    {
                        continue;
                    }
                    else
                    {
                        towns[town][0] = 0;
                        towns[town][1] -= passengers;
                    }
                }
            }

            foreach (var town in towns.OrderBy(n => n.Value[0]).ThenBy(n => n.Key))
            {
                if (town.Value[0] > 0 && town.Value[1] > 0)
                {
                    Console.WriteLine($"{town.Key} -> Time: {town.Value[0]} -> Passengers: {town.Value[1]}");
                }
            }
        }
    }
}
