using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfAttemptedFills = int.Parse(Console.ReadLine());
            int sumLitters = 0;

            for (int i = 0; i < numberOfAttemptedFills; i++)
            {
                int inputLiters = int.Parse(Console.ReadLine());
                sumLitters += inputLiters;
                if (sumLitters > 255)
                {
                    sumLitters -= inputLiters;
                    Console.WriteLine("Insufficient capacity!");
                }
            }

            Console.WriteLine(sumLitters);
        }
    }
}
