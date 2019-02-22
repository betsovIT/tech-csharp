using System;

namespace _01._Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int distInMeters = int.Parse(Console.ReadLine());
            float distInKilometers = distInMeters / 1000.0f;
            Console.WriteLine($"{distInKilometers:F2}");
        }
    }
}
