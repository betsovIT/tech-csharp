using System;
using System.Collections.Generic;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new Dictionary<string, List<double>>();

            string input = Console.ReadLine();

            while (input != "buy")
            {
                string product = input.Split()[0];
                double price = double.Parse(input.Split()[1]);
                double quantiy = double.Parse(input.Split()[2]);

                if (products.ContainsKey(product))
                {
                    products[product][0] = price;
                    products[product][1] += quantiy;
                }
                else
                {
                    products.Add(product,new List<double>{ price, quantiy });
                }
                input = Console.ReadLine();
            }
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Key} -> {product.Value[0]*product.Value[1]:F2}");
            }
        }
    }
}
