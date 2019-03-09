using System;
using System.Globalization;

namespace Sino_The_Walker
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime leaveTime = new DateTime();
            leaveTime = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);

            int steps = int.Parse(Console.ReadLine()) % 86400;
            int timePerStep = int.Parse(Console.ReadLine()) % 86400;

            long additionalTime = steps * timePerStep;

            DateTime arrivalTime = leaveTime.AddSeconds(additionalTime);
            Console.WriteLine("Time Arrival: " + arrivalTime.ToString("HH:mm:ss"));
        }
    }
}
