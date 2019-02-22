using System;

namespace _02._Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            double sumInPounds = double.Parse(Console.ReadLine());
            double sumInDollars = sumInPounds * 1.31;
            Console.WriteLine($"{sumInDollars:F3}");
        }
    }
}
