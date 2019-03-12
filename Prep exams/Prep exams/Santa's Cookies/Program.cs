using System;

namespace Santa_s_Cookies
{
    class Program
    {
        static void Main(string[] args)
        {
            int batches = int.Parse(Console.ReadLine());

            int boxes = 0;

            int singleCookieGrams = 25;
            int cup = 140;
            int smallSpoon = 10;
            int bigSpoon = 20;
            int cookiesPerBox = 5;


            for (int i = 0; i < batches; i++)
            {
                int flourInGrams = int.Parse(Console.ReadLine());
                int sugarInGrams = int.Parse(Console.ReadLine());
                int cocoaInGrams = int.Parse(Console.ReadLine());

                int flourCups = flourInGrams / cup;
                int sugarSpoons = sugarInGrams / bigSpoon;
                int cocoaSpoons = cocoaInGrams / smallSpoon;

                if (flourCups <= 0 || sugarSpoons <= 0|| cocoaSpoons <= 0)
                {
                    Console.WriteLine("Ingredients are not enough for a box of cookies.");
                    continue;
                }

                int totalCookiesForThisBake = (cup + smallSpoon + bigSpoon) * Math.Min(flourCups, Math.Min(sugarSpoons,cocoaSpoons)) / singleCookieGrams;

                int boxesForThisBake = totalCookiesForThisBake / cookiesPerBox;
                Console.WriteLine($"Boxes of cookies: {boxesForThisBake}");

                boxes += boxesForThisBake;
            }
            Console.WriteLine($"Total boxes: {boxes}");
        }
    }
}
