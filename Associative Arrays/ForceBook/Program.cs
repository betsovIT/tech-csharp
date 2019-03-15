using System;
using System.Collections.Generic;
using System.Linq;

namespace ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Dictionary<string, string>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Lumpawaroo")
                {
                    break;
                }

                if (input.Contains('|'))
                {
                    string[] command = input.Split(" | ");

                    string user = command[1];
                    string side = command[0];

                    if (!book.ContainsKey(user))
                    {
                        book.Add(user, side);
                    }
                }
                else if (input.Contains("->"))
                {
                    string[] command = input.Split(" -> ");

                    string user = command[0];
                    string side = command[1];

                    if (book.ContainsKey(user))
                    {
                        book[user] = side;
                    }
                    else
                    {
                        book.Add(user, side);
                    }

                    Console.WriteLine($"{user} joins the {side} side!");
                }
            }

            var bookSorted = book
                .GroupBy(n => n.Value)
                .OrderByDescending(n => n.Count())
                .ThenBy(n => n.Key);

            foreach (var side in bookSorted)
            {

                Console.WriteLine($"Side: {side.Key}, Members: {side.Count()}");

                foreach (var user in side.OrderBy(n => n.Key))
                {
                    Console.WriteLine($"! {user.Key}");
                }
            }

        }
    }
}
