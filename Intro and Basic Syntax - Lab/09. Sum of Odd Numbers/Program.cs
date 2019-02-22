using System;

namespace _09._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int oddCounter = 0;
            int oddNumber = -1;

            while (oddCounter < n)
            {
                oddNumber += 2;
                oddCounter++;
                Console.WriteLine(oddNumber);
                sum += oddNumber;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
