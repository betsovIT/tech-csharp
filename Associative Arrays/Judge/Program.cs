using System;
using System.Collections.Generic;
using System.Linq;

namespace Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            var contests = new Dictionary<string, Dictionary<string, int>>();
            var userStats = new Dictionary<string, Dictionary<string,int>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                if (input[0] == "no more time")
                {
                    break;
                }

                string username = input[0];
                string contest = input[1];
                int points = int.Parse(input[2]);

                if (!contests.ContainsKey(contest))
                {
                    contests.Add(contest, new Dictionary<string, int>());
                    contests[contest].Add(username, points);
                }
                else
                {
                    if (!contests[contest].ContainsKey(username))
                    {
                        contests[contest].Add(username, points);
                    }
                    else
                    {
                        if (contests[contest][username] < points)
                        {
                            contests[contest][username] = points;
                        }
                    }
                }

                if (!userStats.ContainsKey(username))
                {
                    userStats.Add(username, new Dictionary<string, int>());
                    userStats[username].Add(contest, points);
                }
                else
                {
                    if (!userStats[username].ContainsKey(contest))
                    {
                        userStats[username].Add(contest, points);
                    }
                    else
                    {
                        if (userStats[username][contest] < points)
                        {
                            userStats[username][contest] = points;
                        }
                    }
                }
            }

            var orderedUserStats = userStats.OrderByDescending(n => n.Value.Values.Sum()).ThenBy(n => n.Key);

            foreach (var contest in contests)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value.Count()} participants");
                int counter = 0;
                foreach (var item in contest.Value.OrderByDescending(n => n.Value).ThenBy(n => n.Key))
                {
                    counter++;
                    Console.WriteLine($"{counter}. {item.Key} <::> {item.Value}");
                }
            }
            Console.WriteLine("Individual standings:");
            int counterr = 1;
            foreach (var item in orderedUserStats)
            {                
                Console.WriteLine($"{counterr}. {item.Key} -> {item.Value.Values.Sum()}");
                counterr++;
            }
        }
    }
}
