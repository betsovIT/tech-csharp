using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            var contests = new Dictionary<string, string>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of contests")
                {
                    break;
                }
                string[] contest = input.Split(':');
                contests.Add(contest[0], contest[1]);
            }

            var userSubmissions = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of submissions")
                {
                    break;
                }

                string contest = input.Split("=>")[0];
                string password = input.Split("=>")[1];
                string username = input.Split("=>")[2];
                int points = int.Parse(input.Split("=>")[3]);

                if (contests.ContainsKey(contest))
                {
                    if (contests[contest] == password)
                    {
                        if (!userSubmissions.ContainsKey(username))
                        {
                            userSubmissions.Add(username, new Dictionary<string, int>());
                            userSubmissions[username].Add(contest, points);
                        }
                        else
                        {
                            if (!userSubmissions[username].ContainsKey(contest))
                            {
                                userSubmissions[username].Add(contest, points);
                            }
                            else
                            {
                                if (userSubmissions[username][contest] < points)
                                {
                                    userSubmissions[username][contest] = points;
                                }
                            }
                        }
                    }
                }
            }

            string bestCandidate = string.Empty;
            int totalPoints = 0;

            foreach (var user in userSubmissions)
            {
                int currrentPoints = 0;
                foreach (var submission in user.Value)
                {
                    currrentPoints += submission.Value;
                }

                if (currrentPoints > totalPoints)
                {
                    bestCandidate = user.Key;
                    totalPoints = currrentPoints;
                }
            }

            var orderedSubmissions = userSubmissions.OrderBy(n => n.Key);

            Console.WriteLine($"Best candidate is {bestCandidate} with total {totalPoints} points.");
            Console.WriteLine("Ranking: ");
            foreach (var user in orderedSubmissions)
            {
                Console.WriteLine(user.Key);
                var orderedContests = user.Value.OrderByDescending(n => n.Value);
                foreach (var item in orderedContests)
                {
                    Console.WriteLine($"#  {item.Key} -> {item.Value}");
                }
            }

        }
    }
}
