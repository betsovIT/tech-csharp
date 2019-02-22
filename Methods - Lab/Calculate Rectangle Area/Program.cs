using System;

namespace Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            int sideA = int.Parse(Console.ReadLine());
            int sideB = int.Parse(Console.ReadLine());
            Console.WriteLine(CalculateAreaOfRectangle(sideA,sideB));

        }
        static int CalculateAreaOfRectangle( int a, int b)
        {
            return a * b;
        }
    }
}
