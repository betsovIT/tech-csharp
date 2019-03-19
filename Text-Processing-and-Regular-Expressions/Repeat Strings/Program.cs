using System;

namespace Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            foreach (string word in input)
            {
                for (int i = 1; i <= word.Length; i++)
                {
                    Console.Write($"{word}");
                }
            }
            Console.WriteLine();
        }
    }
}
