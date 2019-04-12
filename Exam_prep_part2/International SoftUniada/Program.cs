using System;
using System.Collections.Generic;
using System.Linq;

namespace International_SoftUniada
{
    class Program
    {
        static void Main(string[] args)
        {
            var results = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                string country = input.Split(" -> ")[0];
                string contestant = input.Split(" -> ")[1];
                int score = int.Parse(input.Split(" -> ")[2]);

                bool skip = false;

                if (!results.ContainsKey(country))
                {
                    results.Add(country, new Dictionary<string, int>());
                }

                // Checks if a contestant is playing for two different countries
                foreach (var item in results)
                {
                    if (item.Value.ContainsKey(contestant) && country != item.Key)
                    {
                        skip = true;
                        break;
                    }
                }

                if (skip)
                {
                    continue;
                }

                if (!results[country].ContainsKey(contestant))
                {
                    results[country].Add(contestant, 0);
                }

                results[country][contestant] += score;
            }

            foreach (var country in results.OrderByDescending(n => n.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key}: {country.Value.Values.Sum()}");
                foreach (var contestant in country.Value)
                {
                    Console.WriteLine($" -- {contestant.Key} -> {contestant.Value}");
                }
            }
        }
    }
}
