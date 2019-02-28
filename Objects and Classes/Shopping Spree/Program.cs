using System;
using System.Collections.Generic;

namespace Shopping_Spree
{
    class Person
    {
        public Person()
        {
            ShoppingBag = new List<Product>();
        }

        public string Name { get; set; }
        public int Money { get; set; }
        public List<Product> ShoppingBag { get; set; }

        public void Purchase(Product product)
        {
            if (product.Cost <= Money)
            {
                Money -= product.Cost;
                ShoppingBag.Add(product);
                Console.WriteLine($"{Name} bought {product.Name}");
            }
            else
            {
                Console.WriteLine($"{Name} can't afford {product.Name}");
            }
        }
    }
    class Product
    {
        public string Name { get; set; }
        public int Cost { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Product> productPrices = new List<Product>();

            string[] personInput = Console.ReadLine().Split(';');
            string[] pricesInput = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < personInput.Length; i++)
            {
                string[] personAndBudget = personInput[i].Split('=');

                Person person = new Person();
                person.Name = personAndBudget[0];
                person.Money = int.Parse(personAndBudget[1]);

                people.Add(person);
            }
            for (int i = 0; i < pricesInput.Length; i++)
            {
                string[] itemAndPrice = pricesInput[i].Split('=');

                Product product = new Product();
                product.Name = itemAndPrice[0];
                product.Cost = int.Parse(itemAndPrice[1]);

                productPrices.Add(product);
            }

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] purchase = input.Split();

                Product product = new Product();

                for (int i = 0; i < productPrices.Count; i++)
                {
                    if (purchase[1] == productPrices[i].Name)
                    {
                        product = productPrices[i];
                    }
                }

                for (int i = 0; i < people.Count; i++)
                {
                    if (purchase[0] == people[i].Name)
                    {
                        people[i].Purchase(product);
                    }
                }


                input = Console.ReadLine();
            }

            for (int i = 0; i < people.Count; i++)
            {
                Console.Write($"{people[i].Name} - ");
                if (people[i].ShoppingBag.Count > 0)
                {
                    for (int j = 0; j < people[i].ShoppingBag.Count; j++)
                    {
                        Console.Write(people[i].ShoppingBag[j].Name);
                        if (j < people[i].ShoppingBag.Count - 1)
                        {
                            Console.Write(", ");
                        }
                    }
                }
                else
                {
                    Console.Write("Nothing bought");
                }
                
                Console.WriteLine();

            }

        }
    }
}
