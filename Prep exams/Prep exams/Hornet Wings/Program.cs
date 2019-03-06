using System;

namespace Hornet_Wings
{
    class Program
    {
        static void Main(string[] args)
        {
            int wingFlaps = int.Parse(Console.ReadLine());
            double distancePerThousand = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());

            double distance = wingFlaps / 1000 * distancePerThousand;
            int seconds = wingFlaps / 100;
            seconds += wingFlaps / endurance * 5;

            Console.WriteLine($"{distance:F2} m.");
            Console.WriteLine($"{seconds} s.");

        }
    }
}
