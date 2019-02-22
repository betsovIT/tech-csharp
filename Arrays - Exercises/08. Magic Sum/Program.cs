using System;
using System.Linq;

namespace _08._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int desiredSum = int.Parse(Console.ReadLine());

            for (int i = 0; i < Arr.Length-1; i++)
            {
                for (int j = i+1; j < Arr.Length; j++)
                {
                    if (Arr[i] + Arr[j] == desiredSum)
                    {
                        Console.WriteLine($"{Arr[i]} {Arr[j]}");
                    }
                }
            }
        }
    }
}
