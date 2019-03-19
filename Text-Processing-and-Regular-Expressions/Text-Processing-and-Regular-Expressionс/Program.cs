using System;

namespace Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                Console.Write($"{input} = ");
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    Console.Write($"{input[i]}");
                }
                Console.WriteLine();
            }
        }
    }
}
