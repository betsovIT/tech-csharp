using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int totalExtracedSpice = 0;
            short days = 0;

            while (yield >= 100)
            {
                totalExtracedSpice += yield;
                if (totalExtracedSpice >= 26)
                {
                    totalExtracedSpice -= 26;
                }
                else
                {
                    totalExtracedSpice = 0;
                }
                days++;
                yield -= 10;
            }

            if (totalExtracedSpice >= 26)
            {
                totalExtracedSpice -= 26;
            }
            else
            {
                totalExtracedSpice = 0;
            }

            Console.WriteLine(days);
            Console.WriteLine(totalExtracedSpice);


        }
    }
}
