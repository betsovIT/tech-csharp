using System;
using System.Collections.Generic;
using System.Linq;

namespace Hello__France
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> catalogue = Console.ReadLine().Split('|').ToList();
            double budget = double.Parse(Console.ReadLine());
            List<double> newPrices = new List<double>();
            List<double> profitPerItem = new List<double>();

            for (int i = 0; i < catalogue.Count; i++)
            {
                string[] eachItem = catalogue[i].Split("->");

                if (eachItem[0] == "Clothes" && double.Parse(eachItem[1]) <= 50 && budget >= double.Parse(eachItem[1]))
                {
                    newPrices.Add(double.Parse(eachItem[1])*1.4);
                    profitPerItem.Add(double.Parse(eachItem[1]) * 0.4);
                    budget -= double.Parse(eachItem[1]);
                }
                else if (eachItem[0] == "Shoes" && double.Parse(eachItem[1]) <= 35 && budget >= double.Parse(eachItem[1]))
                {
                    newPrices.Add(double.Parse(eachItem[1])*1.4);
                    profitPerItem.Add(double.Parse(eachItem[1]) * 0.4);
                    budget -= double.Parse(eachItem[1]);
                }
                else if (eachItem[0] == "Accessories" && double.Parse(eachItem[1]) <= 20.5 && budget >= double.Parse(eachItem[1]))
                {
                    newPrices.Add(double.Parse(eachItem[1])*1.4);
                    profitPerItem.Add(double.Parse(eachItem[1]) * 0.4);
                    budget -= double.Parse(eachItem[1]);
                }
            }

            double profit = profitPerItem.Sum();

            for (int i = 0; i < newPrices.Count; i++)
            {
                Console.Write($"{newPrices[i]:F2} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Profit: {profit:F2}");

            if (budget + newPrices.Sum() >= 150)
            {
                Console.WriteLine("Hello, France!");
            }
            else
            {
                Console.WriteLine("Time to go.");
            }


        }
    }
}
