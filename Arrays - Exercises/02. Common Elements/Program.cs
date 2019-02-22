using System;
using System.Linq;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Arr1 = Console.ReadLine().Split().ToArray();
            string[] Arr2 = Console.ReadLine().Split().ToArray();

            for (int i = 0; i < Arr1.Length; i++)
            {
                for (int j = 0; j < Arr2.Length; j++)
                {
                    if (Arr2[j] == Arr1[i])
                    {
                        Console.Write($"{Arr2[j]} ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
