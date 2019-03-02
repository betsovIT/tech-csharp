using System;

namespace Cooking_Masterclass
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double flourPackPrice = double.Parse(Console.ReadLine());
            double eggPrice = double.Parse(Console.ReadLine());
            double appronPrice = double.Parse(Console.ReadLine());

            int appronsCount = (int)Math.Ceiling(students * 1.2);
            int flourPacks = students - students / 5;

            double overallPrice = appronsCount * appronPrice + flourPacks * flourPackPrice + students * eggPrice * 10;

            if (overallPrice <= budget)
            {
                Console.WriteLine($"Items purchased for {overallPrice:F2}$.");
            }
            else
            {
                Console.WriteLine($"{overallPrice-budget:F2}$ more needed.");
            }
        }
    }
}
