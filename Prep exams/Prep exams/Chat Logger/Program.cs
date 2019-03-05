using System;
using System.Collections.Generic;

namespace Chat_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> messages = new List<string>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] command = input.Split();

                if (command[0] == "Chat")
                {
                    messages.Add(command[1]);
                }
                else if (command[0] == "Delete")
                {
                    messages.Remove(command[1]);
                }
                else if (command[0] == "Edit")
                {
                    int toBeEdited = messages.FindIndex(n => n == command[1]);
                    messages.Insert(toBeEdited, command[2]);
                    messages.RemoveAt(toBeEdited + 1);
                }
                else if (command[0] == "Pin")
                {
                    messages.Remove(command[1]);
                    messages.Add(command[1]);
                }
                else if (command[0] == "Spam")
                {
                    for (int i = 1; i < command.Length; i++)
                    {
                        messages.Add(command[i]);
                    }
                }
                input = Console.ReadLine();
            }
            for (int i = 0; i < messages.Count; i++)
            {
                Console.WriteLine(messages[i]);
            }
        }
    }
}
