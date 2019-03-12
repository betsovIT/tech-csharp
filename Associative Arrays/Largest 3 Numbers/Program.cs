using System;
using System.Collections.Generic;
using System.Linq;

namespace Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] sortedNumbers = numbers.OrderByDescending(n => n).ToArray();

            for (int i = 0; i < Math.Min(3,sortedNumbers.Length); i++)
            {
                Console.Write($"{sortedNumbers[i]} ");
            }
            Console.WriteLine();

        }
    }
}
