using System;

namespace _02._From_Left_to_The_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                string input = Console.ReadLine();

                string firstNumberString = "";
                string secondNumberString = "";
                int maxJ = 0;

                for (int j = 0; j < input.Length - 1; j++)
                {
                    if (input[j] == '-')
                    {
                        maxJ++;
                        continue;
                    }
                    maxJ++;
                    if (input[j] == ' ')
                    {
                        break;
                    }
                    firstNumberString = firstNumberString + input[j].ToString();
                }
                for (int k = maxJ; k < input.Length; k++)
                {
                    if (input[k] == '-')
                    {
                        continue;
                    }
                    secondNumberString = secondNumberString + input[k].ToString();
                }

                //Console.WriteLine(firstNumberString);
                //Console.WriteLine(secondNumberString);

                long firstNumber = long.Parse(firstNumberString);
                long secondNumber = long.Parse(secondNumberString);

                if (input[maxJ] == '-')
                {
                    secondNumber = secondNumber * -1;
                }

                if (input[0] == '-')
                {
                    firstNumber = firstNumber * -1;
                }

                if (firstNumber>=secondNumber)
                {
                    long digit = Math.Abs(firstNumber);
                    long sumDigit = 0;

                    while (digit > 0)
                    {
                        sumDigit += digit % 10;
                        digit = digit / 10;
                    }
                    Console.WriteLine(sumDigit);
                }
                else
                {
                    long digit = Math.Abs(secondNumber);
                    long sumDigit = 0;

                    while (digit > 0)
                    {
                        sumDigit += digit % 10;
                        digit = digit / 10;
                    }
                    Console.WriteLine(sumDigit);
                }
            }
        }
    }
}
