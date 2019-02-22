using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            OrderCalculator(product, quantity);
        }
        static void OrderCalculator(string product, int quantity)
        {
            switch (product)
            {
                case "coffee": Console.WriteLine($"{1.5 * quantity:F2}"); break;
                case "water": Console.WriteLine($"{1.0 * quantity:F2}"); break;
                case "coke": Console.WriteLine($"{1.4 * quantity:F2}"); break;
                case "snacks": Console.WriteLine($"{2 * quantity:F2}"); break;
                default:
                    break;
            }
        }
    }
}
