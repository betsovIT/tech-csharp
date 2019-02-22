using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacityPerRide = int.Parse(Console.ReadLine());

            double trips = people / (double)capacityPerRide;

            Console.WriteLine(Math.Ceiling(trips));
        }
    }
}
