using System;

namespace Ascii_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstSymbolCode = Console.ReadLine()[0];
            int secondSymbolCode = Console.ReadLine()[0];
            string input = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > firstSymbolCode && input[i] < secondSymbolCode)
                {
                    sum += input[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
