using System;
using System.Text.RegularExpressions;

namespace Chore_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex dishes = new Regex(@"(?<=<)([a-z0-9]*)(?=>)");
            Regex cleaning = new Regex(@"(?<=\[)([A-Z0-9]*)(?=\])");
            Regex laundry = new Regex(@"(?<=\{)(.*)(?=\})");

            double timeDishes = 0;
            double timeCleaning = 0;
            double timeLaundry = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "wife is happy")
                {
                    break;
                }

                if (dishes.IsMatch(input))
                {
                    string match = dishes.Match(input).Value;

                    for (int i = 0; i < match.Length; i++)
                    {
                        if (Char.IsDigit(match[i]))
                        {
                            timeDishes += Char.GetNumericValue(match[i]);
                        }
                    }
                }
                else if (cleaning.IsMatch(input))
                {
                    string match = cleaning.Match(input).Value;

                    for (int i = 0; i < match.Length; i++)
                    {
                        if (Char.IsDigit(match[i]))
                        {
                            timeCleaning += Char.GetNumericValue(match[i]);
                        }
                    }
                }
                else if (laundry.IsMatch(input))
                {
                    string match = laundry.Match(input).Value;

                    for (int i = 0; i < match.Length; i++)
                    {
                        if (Char.IsDigit(match[i]))
                        {
                            timeLaundry += Char.GetNumericValue(match[i]);
                        }
                    }
                }
            }

            Console.WriteLine($"Doing the dishes - {timeDishes} min.");
            Console.WriteLine($"Cleaning the house - {timeCleaning} min.");
            Console.WriteLine($"Doing the laundry - {timeLaundry} min.");
            Console.WriteLine($"Total - {timeLaundry+timeDishes+timeCleaning} min.");
        }
    }
}
