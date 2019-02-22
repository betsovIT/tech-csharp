using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int sumOfDigits = 0;
                int num = i;
                bool divisionToZero = false;

                while (num > 0)
                {
                    sumOfDigits += num % 10;
                    num = num / 10;
                }

                if (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11)
                {
                    divisionToZero = true;
                }

                Console.WriteLine($"{i} -> {divisionToZero}");
            }
        }
    }
}
