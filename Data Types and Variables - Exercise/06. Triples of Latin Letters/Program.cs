using System;

namespace _06._Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLetters = int.Parse(Console.ReadLine());

            for (int i = 97; i < 97+numberOfLetters; i++)
            {
                for (int j = 97; j < 97 + numberOfLetters; j++)
                {
                    for (int k = 97; k < 97 + numberOfLetters; k++)
                    {
                        Console.WriteLine($"{(char)i}{(char)j}{(char)k}");
                    }
                }
            }
        }
    }
}
