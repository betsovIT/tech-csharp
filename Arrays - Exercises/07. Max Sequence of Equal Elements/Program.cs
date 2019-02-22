using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int maxCounter = 1;
            int currCounter = 1;
            int endIndex = 0;

            for (int i = 0; i < Arr.Length-1; i++)
            {
                if (Arr[i] == Arr[i + 1])
                {
                    currCounter++;
                    if (currCounter > maxCounter)
                    {
                        maxCounter = currCounter;
                        endIndex = i + 1;
                    }
                }
                else
                {
                    currCounter = 1;
                    continue;
                }

            }

            for (int i = endIndex+1 - maxCounter; i <= endIndex; i++)
            {
                Console.Write($"{Arr[i]} ");
            }
            Console.WriteLine();
        }
    }
}
