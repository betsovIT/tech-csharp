using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int counter = 0;

            for (int i = 0; i < Arr.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                if (i == 0)
                {
                    leftSum = 0;
                }
                else
                {
                    for (int j = 0; j < i; j++)
                    {
                        leftSum += Arr[j];
                    }
                }

                if (i == Arr.Length-1)
                {
                    rightSum = 0;
                }
                else
                {
                    for (int j = i+1; j < Arr.Length; j++)
                    {
                        rightSum += Arr[j];
                    }
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    counter++;
                }
            }

            if (counter == 0)
            {
                Console.WriteLine("no");
            }
        }
    }
}
