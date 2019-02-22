using System;

namespace Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(VowelCounter(Console.ReadLine()));
        }
        static int VowelCounter(string input)
        {
            int vowelSum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'A' || input[i] == 'e' || input[i] == 'E'
                        || input[i] == 'i' || input[i] == 'I' || input[i] == 'o' || input[i] == 'O'
                            || input[i] == 'u' || input[i] == 'U')
                {
                    vowelSum++;
                }
                else
                {
                    continue;
                }
            }
            return vowelSum;
        }
    }
}
