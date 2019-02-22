using System;

namespace _04._Print_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = k; i <= n; i++)
            {
                if (i < n)
                {
                    Console.Write($"{i} ");
                }
                else
                {
                    Console.WriteLine($"{i}");
                }
                sum += i;
                if (i == n)
                {
                    Console.WriteLine($"Sum: {sum}");
                }
            }
        }
    }
}
