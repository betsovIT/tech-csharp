using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            string input = "";

            while (true)
            {
                input = Console.ReadLine();
                if (input == "Start")
                {
                    break;
                }

                if (double.Parse(input)!=0.1 &&
                        double.Parse(input) != 0.2 &&
                            double.Parse(input) != 0.5 &&
                                double.Parse(input) != 1 &&
                                    double.Parse(input) != 2)
                {
                    Console.WriteLine($"Cannot accept {input}");
                    continue;
                }
                sum += double.Parse(input);
            }

            while (true)
            {
                input = Console.ReadLine();

                if (input == "End")
                {
                    Console.WriteLine($"Change: {sum:F2}");
                    break;
                }

                if (input == "Nuts")
                {
                    sum -= 2;
                    if (sum < 0)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        sum += 2;
                        continue;
                    }
                    Console.WriteLine("Purchased nuts");
                }
                else if (input == "Water")
                {
                    sum -= 0.7;
                    if (sum < 0)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        sum += 0.7;
                        continue;
                    }
                    Console.WriteLine("Purchased water");
                }
                else if (input == "Crisps")
                {
                    sum -= 1.5;
                    if (sum < 0)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        sum += 1.5;
                        continue;
                    }
                    Console.WriteLine("Purchased crisps");
                }
                else if (input == "Soda")
                {
                    sum -= 0.8;
                    if (sum < 0)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        sum += 0.8;
                        continue;
                    }
                    Console.WriteLine("Purchased soda");
                }
                else if (input == "Coke")
                {
                    sum -= 1;
                    if (sum < 0)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        sum += 1;
                        continue;
                    }
                    Console.WriteLine("Purchased coke");
                }
                else
                {
                    Console.WriteLine( "Invalid product");
                }
            }
        }
    }
}
