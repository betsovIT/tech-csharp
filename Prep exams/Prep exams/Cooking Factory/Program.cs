using System;
using System.Linq;

namespace Cooking_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int bestTotalQuality = int.MinValue;
            int bestAverageQuality = int.MinValue;
            int fewestElements = int.MaxValue;
            string bestBatch = "";

            while (input != "Bake It!")
                {
                int[] breadBatch = input.Split('#').Select(int.Parse).ToArray();
                int totalQuality = breadBatch.Sum();
                int averageQuality = breadBatch.Sum() / breadBatch.Length;

                if (totalQuality > bestTotalQuality)
                {
                    bestTotalQuality = totalQuality;
                    bestAverageQuality = averageQuality;
                    bestBatch = string.Join(' ', breadBatch);
                    fewestElements = breadBatch.Length;
                }
                else if (totalQuality == bestTotalQuality && averageQuality > bestAverageQuality)
                {
                    bestTotalQuality = totalQuality;
                    bestAverageQuality = averageQuality;
                    bestBatch = string.Join(' ', breadBatch);
                    fewestElements = breadBatch.Length;
                }
                else if (totalQuality == bestTotalQuality && averageQuality == bestAverageQuality && breadBatch.Length < fewestElements)
                {
                    bestTotalQuality = totalQuality;
                    bestAverageQuality = averageQuality;
                    bestBatch = string.Join(' ', breadBatch);
                    fewestElements = breadBatch.Length;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Best Batch quality: {bestTotalQuality}");
            Console.WriteLine(bestBatch);
        }
    }
}
