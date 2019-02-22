using System;

namespace Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{ FactorielCalculator(int.Parse(Console.ReadLine())) / FactorielCalculator(int.Parse(Console.ReadLine())):F2}");
        }
        static double FactorielCalculator(int num)
        {
            if (num == 0)
            {
                return 1;
            }
            return num * FactorielCalculator(num - 1);

        }
    }
}
