using System;
using System.Collections.Generic;

namespace Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Dictionary<string, int> occurences = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                string wordToLowerCase = words[i].ToLower();

                if (occurences.ContainsKey(wordToLowerCase))
                {
                    occurences[wordToLowerCase]++;
                }
                else
                {
                    occurences.Add(wordToLowerCase, 1);
                }
            }

            foreach (var word in occurences)
            {
                if (word.Value % 2 != 0)
                {
                    Console.Write($"{word.Key} ");
                }
            }
            Console.WriteLine();
        }
    }
}
