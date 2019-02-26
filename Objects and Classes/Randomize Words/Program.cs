using System;

namespace Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Random rand = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                int randNum = rand.Next(input.Length);
                string container = input[i];
                input[i] = input[randNum];
                input[randNum] = container;
            }
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i]);
            }
        }
    }
}
