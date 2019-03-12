using System;

namespace Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int runners = int.Parse(Console.ReadLine());
            int averageLaps = int.Parse(Console.ReadLine());
            int trackLength = int.Parse(Console.ReadLine());
            int trackCapasity = int.Parse(Console.ReadLine());
            double moneyPerKilometer = double.Parse(Console.ReadLine());

            int maxRunners = days * trackCapasity;

            double moneyRaised = Math.Min((days * trackCapasity), runners) * averageLaps * trackLength * moneyPerKilometer/1000;

            Console.WriteLine($"Money raised: {moneyRaised:F2}");
        }
    }
}
