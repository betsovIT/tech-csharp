using System;

namespace _01._Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStrings = int.Parse(Console.ReadLine());
            int[] values = new int[numberOfStrings];

            for (int i = 0; i < numberOfStrings; i++)
            {
                string input = Console.ReadLine();
                int sum = 0;
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] == 'a' || input[j] == 'e' || input[j] == 'o' || input[j] == 'u' || input[j] == 'i' 
                        || input[j] == 'A' || input[j] == 'E' || input[j] == 'O' || input[j] == 'U' ||  input[j] == 'I')
                    {
                        sum += (int)input[j] * input.Length;
                    }
                    else
                    {
                        sum += (int)input[j] / input.Length;
                    }
                }
                values[i] = sum;
            }

            Array.Sort(values);

            foreach (int value in values)
            {
                Console.WriteLine(value);
            }
        }
    }
}
