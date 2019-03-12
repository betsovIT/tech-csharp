using System;
using System.Collections.Generic;
using System.Linq;

namespace ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "Lumpawaroo")
            {
                bool firstcase = false;
                bool secondcase = false;
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] == '|')
                    {
                        firstcase = true;
                    }
                    else if (input[i] == '>')
                    {
                        secondcase = true;
                    }
                }
                if (firstcase)
                {
                    string side = input.Split(" | ")[0];
                    string user = input.Split(" | ")[1];

                    bool exists = false;

                    foreach (var item in book)
                    {
                        foreach (var j in item.Value)
                        {
                            if (j == user)
                            {
                                exists = true;
                            }
                        }
                    }
                    if (!exists)
                    {
                        if (!book.ContainsKey(side))
                        {
                            book.Add(side, new List<string>());
                        }
                        book[side].Add(user);                        
                    }
                }
                else if (secondcase)
                {
                    string side = input.Split(" -> ")[1];
                    string user = input.Split(" -> ")[0];

                    bool exists = false;
                    string tempSide = string.Empty;

                    foreach (var item in book)
                    {
                        foreach (var j in item.Value)
                        {
                            if (j == user)
                            {
                                exists = true;
                                tempSide = item.Key;
                            }
                        }
                    }

                    if (!exists)
                    {
                        if (!book.ContainsKey(side))
                        {
                            book.Add(side, new List<string> { user });
                        }
                        book[side].Add(user);

                        Console.WriteLine($"{user} joins the {side} side!");
                    }
                    else
                    {
                        book[tempSide].Remove(user);
                        book[side].Add(user);

                        Console.WriteLine($"{user} joins the {side} side!");
                    }
                }
                input = Console.ReadLine();
            }

            var orderedSides = book.OrderByDescending(n => n.Value.Count).ThenBy(n => n.Key);
            var orderedUsers = new Dictionary<string, List<string>>();

            foreach (var item in orderedSides)
            {
                orderedUsers.Add(item.Key, item.Value.OrderBy(n => n).ToList());
            }

            foreach (var item in orderedUsers)
            {
                if (item.Value.Count>0)
                {
                    Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count}");
                    foreach (var j in item.Value)
                    {
                        Console.WriteLine($"! {j}");
                    }
                }
            }
        }
    }
}
