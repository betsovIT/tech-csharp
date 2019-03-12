using System;
using System.Collections.Generic;

namespace Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            var charCount = new Dictionary<char, int>();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ' && charCount.ContainsKey(str[i]))
                {
                    charCount[str[i]]++;                    
                }
                else if (str[i] != ' ' && !charCount.ContainsKey(str[i]))
                {
                    charCount.Add(str[i], 1);
                }                
            }

            foreach (var item in charCount)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
