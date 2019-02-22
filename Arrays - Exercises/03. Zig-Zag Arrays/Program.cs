using System;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            int[] firstArray = new int[lines];
            int[] secondArray = new int[lines];

            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();
                int strIndex = input.IndexOf(' ');
                if (i % 2 != 0)
                {
                    firstArray[i] = int.Parse(input.Substring(0, strIndex));
                    secondArray[i] = int.Parse(input.Substring(strIndex));
                }
                else
                {
                    secondArray[i] = int.Parse(input.Substring(0, strIndex));
                    firstArray[i] = int.Parse(input.Substring(strIndex));
                }
            }

            for (int i = 0; i < lines; i++)
            {
                Console.Write($"{secondArray[i]} ");
            }
            Console.WriteLine();

            for (int i = 0; i < lines; i++)
            {
                Console.Write($"{firstArray[i]} ");
            }
            Console.WriteLine();



        }
    }
}
