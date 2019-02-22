using System;

namespace Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintCharactersInRange(char.Parse(Console.ReadLine()), char.Parse(Console.ReadLine()));
        }
        static void PrintCharactersInRange(char start, char end)
        {
            for (int i = Math.Min((int)start,(int)end)+1; i < Math.Max((int)start, (int)end); i++)
            {
                Console.Write($"{(char)i} ");
            }
            Console.WriteLine();
        }
    }
}
