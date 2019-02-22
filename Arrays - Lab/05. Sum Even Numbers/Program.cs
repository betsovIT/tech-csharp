using System;

namespace _05._Sum_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberString = Console.ReadLine();
            string[] stringArr = numberString.Split();
            int[] intArray = new int[stringArr.Length];

            for (int i = 0; i < stringArr.Length ; i++)
            {
                intArray[i] = int.Parse(stringArr[i]);
            }

            int sum = 0;

            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] % 2 == 0)
                {
                    sum += intArray[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
