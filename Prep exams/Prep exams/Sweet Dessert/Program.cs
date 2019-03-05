using System;

namespace Sweet_Dessert
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int guests = int.Parse(Console.ReadLine());

            double bananaPrice = double.Parse(Console.ReadLine());
            double eggsPrice = double.Parse(Console.ReadLine());
            double berriesPrice = double.Parse(Console.ReadLine());

            double bananasForABatch = 2;
            double eggsForABatch = 4;
            double berriesKillosForABatch = 0.2;

            double batches = Math.Ceiling(guests / 6d);

            double moneyNeeded = (bananasForABatch * bananaPrice + eggsForABatch * eggsPrice + berriesKillosForABatch * berriesPrice) * batches;

            if (moneyNeeded <= budget)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {moneyNeeded:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {moneyNeeded - budget:F2}lv more.");
            }
        }
    }
}
