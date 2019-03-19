using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<string> messages = new List<string>();

            for (int i = 0; i < lines; i++)
            {
                string message = Console.ReadLine();

                int specialCharCount = 0;

                for (int j = 0; j < message.Length; j++)
                {
                    if (message[j] == 'S' || message[j] == 's' || message[j] == 'T' || message[j] == 't' || message[j] == 'A' || message[j] == 'a' || message[j] == 'R' || message[j] == 'r')
                    {
                        specialCharCount++;
                    }
                }
                StringBuilder newMessage = new StringBuilder();

                for (int j = 0; j < message.Length; j++)
                {
                    int charRepresentation = message[j];
                    newMessage.Append((char)(charRepresentation - specialCharCount));
                }

                messages.Add(newMessage.ToString());
            }

            List<string> atackedPlanets = new List<string>();
            List<string> defendedPlanets = new List<string>();

            for (int i = 0; i < messages.Count; i++)
            {
                MatchCollection matches = Regex.Matches(messages[i], @"@([a-zA-Z]+)[^@\-!:>]*:[0-9]+[^@\-!:>]*!([AD])![^@\-!:>]*->[0-9]+");

                foreach (Match match in matches)
                {
                    string planet = match.Groups[1].Value;
                    string engagement = match.Groups[2].Value;

                    if (engagement == "A")
                    {
                        atackedPlanets.Add(planet);
                    }
                    else if (engagement == "D")
                    {
                        defendedPlanets.Add(planet);
                    }
                }
            }


            Console.WriteLine($"Attacked planets: {atackedPlanets.Count}");
            foreach (var item in atackedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {item}");
            }
            Console.WriteLine($"Destroyed planets: {defendedPlanets.Count}");
            foreach (var item in defendedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {item}");
            }
        }
    }
}
