using System;

namespace _04._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfChars = int.Parse(Console.ReadLine());
            int totalSumOfValues = 0;

            for (int i = 1; i <= numberOfChars; i++)
            {
                char input = char.Parse(Console.ReadLine());
                int valueOfChar = (int)input;

                totalSumOfValues += valueOfChar;
            }

            Console.WriteLine($"The sum equals: {totalSumOfValues}");
        }
    }
}
