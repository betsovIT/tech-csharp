using System;
using System.Collections.Generic;
using System.Linq;

namespace Quests_Journal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> journal = Console.ReadLine().Split(", ").ToList();

            string input = Console.ReadLine();

            while (input != "Retire!")
            {
                string[] command = input.Split(" - ");

                if (command[0] == "Start")
                {
                    if (!journal.Contains(command[1]))
                    {
                        journal.Add(command[1]);
                    }
                }
                else if (command[0] == "Complete")
                {
                    journal.Remove(command[1]);
                }
                else if (command[0] == "Side Quest")
                {
                    string[] partialCommand = command[1].Split(':');

                    if (journal.Contains(partialCommand[0]) && !journal.Contains(partialCommand[1]))
                    {
                        int questIndex = journal.FindIndex(n => n == partialCommand[0]);
                        journal.Insert(questIndex + 1, partialCommand[1]);
                    }
                }
                else if (command[0] == "Renew")
                {
                    if (journal.Contains(command[1]))
                    {
                        journal.Remove(command[1]);
                        journal.Add(command[1]);
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ",journal));
        }
    }
}
