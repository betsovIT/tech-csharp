using System;

namespace _02._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputInteger = int.Parse(Console.ReadLine());
            int digitSum = 0;
            int digit = inputInteger;

            while (digit > 0)
            {
                digitSum += digit % 10;
                digit = digit / 10;
            }


            Console.WriteLine(digitSum);
        }
    }
}
