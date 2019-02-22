using System;
using System.Linq;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());
            int[] rotated = new int[Arr.Length];

            for (int i = 0; i < rotations; i++)
            {
                for (int j = 0; j < Arr.Length; j++)
                {
                    if (j == Arr.Length - 1)
                    {
                        rotated[j] = Arr[0];
                    }
                    else
                    {
                        rotated[j] = Arr[j + 1];
                    }
                }
               Array.Copy(rotated,0,Arr,0,rotated.Length);
            }

            for (int i = 0; i < Arr.Length; i++)
            {
                Console.Write($"{Arr[i]} ");
            }
            Console.WriteLine();
        }
    }
}
