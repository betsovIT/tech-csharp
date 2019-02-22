using System;

namespace _03._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double ballance = double.Parse(Console.ReadLine());
            double spent = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Game Time")
                {
                    Console.WriteLine($"Total spent: ${spent:F2}. Remaining: ${ballance:F2}");
                    return;
                }

                if (ballance == 0)
                {
                    Console.WriteLine("Out of Money!");
                    return;
                }

                if (input == "OutFall 4")
                {
                    ballance -= 39.99;
                    spent += 39.99;
                    if (ballance < 0)
                    {
                        Console.WriteLine("Too Expensive");
                        ballance += 39.99;
                        spent -= 39.99;
                        continue;
                    }
                    Console.WriteLine("Bought OutFall 4");
                }
                else if (input == "CS: OG")
                {
                    ballance -= 15.99;
                    spent += 15.99;
                    if (ballance < 0)
                    {
                        Console.WriteLine("Too Expensive");
                        ballance += 15.99;
                        spent -= 15.99;
                        continue;
                    }
                    Console.WriteLine("Bought CS: OG");
                }
                else if (input == "Zplinter Zell")
                {
                    ballance -= 19.99;
                    spent += 19.99;
                    if (ballance < 0)
                    {
                        Console.WriteLine("Too Expensive");
                        ballance += 19.99;
                        spent -= 19.99;
                        continue;
                    }
                    Console.WriteLine("Bought Zplinter Zell");
                }
                else if (input == "Honored 2")
                {
                    ballance -= 59.99;
                    spent += 59.99;
                    if (ballance < 0)
                    {
                        Console.WriteLine("Too Expensive");
                        ballance += 59.99;
                        spent -= 59.99;
                        continue;
                    }
                    Console.WriteLine("Bought Honored 2");
                }
                else if (input == "RoverWatch")
                {
                    ballance -= 29.99;
                    spent += 29.99;
                    if (ballance < 0)
                    {
                        Console.WriteLine("Too Expensive");
                        ballance += 29.99;
                        spent -= 29.99;
                        continue;
                    }
                    Console.WriteLine("Bought RoverWatch");
                }
                else if (input == "RoverWatch Origins Edition")
                {
                    ballance -= 39.99;
                    spent += 39.99;
                    if (ballance < 0)
                    {
                        Console.WriteLine("Too Expensive");
                        ballance += 39.99;
                        spent -= 39.99;
                        continue;
                    }
                    Console.WriteLine("Bought RoverWatch Origins Edition");
                }
                else
                {
                    Console.WriteLine("Not Found");
                }
            }
        }
    }
}
