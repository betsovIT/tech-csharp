using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionaryTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] definitions = Console.ReadLine().Split(" | ", StringSplitOptions.RemoveEmptyEntries);
            string[] wordsToPrint = Console.ReadLine().Split(" | ", StringSplitOptions.RemoveEmptyEntries);
            string finalCommand = Console.ReadLine();
            var wordKeys = new List<string>();

            var wordDictionary = new Dictionary<string, List<string>>();

            foreach (var definition in definitions)
            {
                string word = definition.Split(": ")[0];
                string def = definition.Split(": ")[1];

                if (!wordKeys.Contains(word))
                {
                    wordKeys.Add(word);
                }

                if (!wordDictionary.ContainsKey(word))
                {
                    wordDictionary.Add(word, new List<string>());
                }

                if (!wordDictionary[word].Contains(def))
                {
                    wordDictionary[word].Add(def);
                }
            }

            foreach (var word in wordsToPrint)
            {
                if (wordDictionary.ContainsKey(word))
                {
                    Console.WriteLine($@"{word}");
                    foreach (var def in wordDictionary[word].OrderByDescending(n => n.Length))
                    {
                        Console.WriteLine($" -{def}");
                    }
                }
                
            }

            if (finalCommand == "List")
            {
                var newWordKeys = wordKeys.OrderBy(n => n);

                Console.WriteLine(string.Join(' ',newWordKeys));
            }
        }
    }
}
