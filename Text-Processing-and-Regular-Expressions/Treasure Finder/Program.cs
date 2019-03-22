using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Treasure_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> keys = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "find")
                {
                    break;
                }

                StringBuilder sb = new StringBuilder();
                int rotationCounter = 0;

                for (int i = 0; i < input.Length; i++)
                {
                    sb.Append((char)(input[i] - keys[rotationCounter]));
                    rotationCounter++;
                    if (rotationCounter == keys.Count)
                    {
                        rotationCounter = 0;
                    }
                }
                string decodedMessage = sb.ToString();

                Match treasure = Regex.Match(decodedMessage, @"(?<=&)(.*)(?=&)");
                Match coordinates = Regex.Match(decodedMessage, @"(?<=<)(.*)(?=>)");

                Console.WriteLine($"Found {treasure.Value} at {coordinates.Value}");
            }
        }
    }
}
