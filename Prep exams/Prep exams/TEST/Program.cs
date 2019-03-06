using System;
using System.Collections.Generic;

namespace Hornet_Comm
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> privateMessages = new List<string>();
            List<string> broadcasts = new List<string>();

            while (input != "Hornet is Green")
            {
                bool isBroadcast = true;
                bool isMessage = true;

                string[] separators = { " <-> " };
                string[] message = input.Split(separators,StringSplitOptions.None);

                for (int i = 0; i < message[0].Length; i++)
                {
                    if (message[0][i] < 48 || message[0][i] > 57)
                    {
                        isMessage = false;
                    }
                    if (message[0][i] > 47 && message[0][i] < 58)
                    {
                        isBroadcast = false;
                    }
                }
                for (int i = 0; i < message[1].Length; i++)
                {
                    if (message[1][i] < 48 || (message[1][i] > 57 && message[1][i] < 65) || (message[1][i] > 90 && message[1][i] < 97) || message[1][i] > 122)
                    {
                        isMessage = false;
                        isBroadcast = false;
                    }
                }
                if (isMessage && !isBroadcast)
                {
                    string codeReversed = string.Empty;
                    for (int i = message[0].Length - 1; i >= 0; i--)
                    {
                        codeReversed += message[0][i];
                    }

                    privateMessages.Add(codeReversed + " -> " + message[1]);
                }
                if (!isMessage && isBroadcast)
                {
                    string reversedCapitalization = string.Empty;

                    for (int i = 0; i < message[1].Length; i++)
                    {
                        char tempChar = message[1][i];
                        if (Char.IsUpper(tempChar))
                        {
                            reversedCapitalization += Char.ToLower(tempChar);
                        }
                        else
                        {
                            reversedCapitalization += Char.ToUpper(tempChar);
                        }
                    }
                    broadcasts.Add(reversedCapitalization + " -> " + message[0]);
                }
                input = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");
            if (broadcasts.Count < 1)
            {
                Console.WriteLine("None");
            }
            else
            {
                for (int i = 0; i < broadcasts.Count; i++)
                {

                    Console.WriteLine(broadcasts[i]);
                }
            }
            Console.WriteLine("Messages:");
            if (privateMessages.Count < 1)
            {
                Console.WriteLine("None");
            }
            else
            {
                for (int i = 0; i < privateMessages.Count; i++)
                {

                    Console.WriteLine(privateMessages[i]);
                }
            }

        }
    }
}
