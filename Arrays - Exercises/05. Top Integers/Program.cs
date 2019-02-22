using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < Arr.Length-1; i++)
            {
                for (int j = i+1; j < Arr.Length; j++)
                {
                    if (Arr[i] > Arr[j])
                    {
                        if (Arr[i] > Arr[j] && j == Arr.Length -1)
                        {
                            Console.Write($"{Arr[i]} ");
                        }
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.Write($"{Arr[Arr.Length-1]} ");
            Console.WriteLine();
        }
    }
}
