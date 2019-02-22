using System;

namespace _02._Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());

            int[] numArray = new int[numbersCount];

            for (int i = 0; i < numbersCount; i++)
            {
                numArray[i] = int.Parse(Console.ReadLine());
            }

            for (int j = numbersCount-1; j >= 0; j--)
            {
                Console.Write(numArray[j]+" ");
            }
            Console.WriteLine();
        }
    }
}
