using System;
using System.Collections.Generic;
using System.Linq;

namespace Concert
{
    class Program
    {
        static void Main(string[] args)
        {
            var bandMembers = new Dictionary<string, List<string>>();
            var bandPlayTime = new Dictionary<string, long>();

            string[] separators = { ", ", "; " };

            while (true)
            {
                string[] input = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "start of concert")
                {
                    break;
                }

                if (input[0] == "Add")
                {
                    string band = input[1];
                    var members = new List<string>();

                    for (int i = 2; i < input.Length; i++)
                    {
                        members.Add(input[i]);
                    }

                    if (!bandMembers.ContainsKey(band))
                    {
                        bandMembers.Add(band, members);
                    }
                    else
                    {
                        foreach (var member in members)
                        {
                            if (!bandMembers[band].Contains(member))
                            {
                                bandMembers[band].Add(member);
                            }
                        }
                    }
                }
                else if (input[0] == "Play")
                {
                    string band = input[1];
                    long time = long.Parse(input[2]);
                    if (!bandPlayTime.ContainsKey(band))
                    {
                        bandPlayTime.Add(band, time);
                    }
                    else
                    {
                        bandPlayTime[band] += time;
                    }

                }
            }

            string bandToPrint = Console.ReadLine();

            var orderedByPlayTime = bandPlayTime.OrderByDescending(n => n.Value).ThenBy(n => n.Key);

            Console.WriteLine($"Total time: {bandPlayTime.Sum(n => n.Value)}");
            foreach (var band in orderedByPlayTime)
            {
                Console.WriteLine($"{band.Key} -> {band.Value}");
            }

            Console.WriteLine(bandToPrint);
            foreach (var member in bandMembers[bandToPrint])
            {
                Console.WriteLine($"=> {member}");
            }
        }
    }
}
