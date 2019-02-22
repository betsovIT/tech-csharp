using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int beginningOfTable = int.Parse(Console.ReadLine());
            int endOfTable = int.Parse(Console.ReadLine());

            for (int i = beginningOfTable; i <= endOfTable; i++)
            {
                Console.Write($"{(char)i} ");
            }
            Console.WriteLine();
        }
    }
}