using System;

namespace _03._Floating_Equality
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Math.Abs(double.Parse(Console.ReadLine()));
            double b = Math.Abs(double.Parse(Console.ReadLine()));

            if (Math.Abs(a - b) > 0.000001)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }

        }
    }
}
