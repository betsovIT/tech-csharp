using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] Arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isDifferent = false;
            int sum = 0;

            for (int i = 0; i < Math.Max(Arr1.Length,Arr2.Length); i++)
            {
                if (Arr1[i] != Arr2[i])
                {
                    isDifferent = true;
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }
                else
                {
                    sum += Arr1[i];
                }
            }

            if (isDifferent == false)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}
