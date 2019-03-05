using System;
using System.Collections.Generic;

namespace Santa_s_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> kids = new List<string>();

            string[] input = Console.ReadLine().Split('&');

            for (int i = 0; i < input.Length; i++)
            {
                kids.Add(input[i]);
            }

            string command = Console.ReadLine();

            while (command != "Finished!")
            {
                string[] commandArgs = command.Split();

                if (commandArgs[0] == "Bad")
                {
                    if (kids.Contains(commandArgs[1]))
                    {
                        continue;
                    }
                    else
                    {
                        kids.Insert(0, commandArgs[1]);
                    }
                }
                else if (commandArgs[0] == "Good")
                {
                    kids.Remove(commandArgs[1]);
                }
                else if (commandArgs[0] == "Rename")
                {
                    if (kids.Contains(commandArgs[1]))
                    {
                        int kidIndex = kids.FindIndex(n => n == commandArgs[1]);
                        kids[kidIndex] = commandArgs[2];
                    }
                }
                else if (commandArgs[0] == "Rearrange")
                {
                    if (kids.Contains(commandArgs[1]))
                    {
                        kids.Remove(commandArgs[1]);
                        kids.Add(commandArgs[1]);
                    }                    
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", kids));
        }
    }
}
