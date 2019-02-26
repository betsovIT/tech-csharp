using System;
using System.Numerics;

namespace Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            short N = short.Parse(Console.ReadLine());
            BigInteger result = 1;

            for (int i = 1; i <= N; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }
    }
}
