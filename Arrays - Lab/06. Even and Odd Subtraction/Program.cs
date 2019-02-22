using System;

namespace _06._Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            string[] ArrAsString = inputString.Split();
            int[] ArrAsInt = new int[ArrAsString.Length];

            for (int i = 0; i < ArrAsString.Length; i++)
            {
                ArrAsInt[i] = int.Parse(ArrAsString[i]);
            }

            int oddSum = 0;
            int evenSum = 0;

            for (int i = 0; i < ArrAsInt.Length; i++)
            {
                if (ArrAsInt[i] % 2 == 0)
                {
                    evenSum += ArrAsInt[i];
                }
                else
                {
                    oddSum += ArrAsInt[i];
                }
            }
            Console.WriteLine(evenSum-oddSum);
        }
    }
}
