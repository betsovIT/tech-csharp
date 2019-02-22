using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = int.Parse(Console.ReadLine());
            for (int i = 1; i <= limit; i++)
            {
                int digit = i;
                int digitSum = 0;
                while (digit > 0)
                {
                    digitSum += digit % 10;
                    digit = digit / 10;
                }
                bool digitSumIs5_7_11 = false;
                if (digitSum == 5 || digitSum == 7 || digitSum == 11)
                {
                    digitSumIs5_7_11 = true;
                }

                Console.WriteLine($"{i} -> {digitSumIs5_7_11}");

            }

        }
    }
}
