using System;
using System.Linq;

namespace _04._Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] unfolded = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int k = unfolded.Length / 4;

            int[] firstFolded = new int[2 * k];
            int[] secondFolded = new int[2 * k];

            int[] summedFolds = new int[2 * k];

            for (int i = 0; i < k; i++)
            {
                firstFolded[i] = unfolded[k-i-1];
            }
            //for (int i = unfolded.Length - 1; i > unfolded.Length-1-k; i--)
            //{
            //    firstFolded[@-i)] = unfolded[i];
            //}

            for (int i = k; i > 0; i--)
            {
                firstFolded[2*k-i] = unfolded[unfolded.Length-1-k+i];
            }

            for (int i = k; i < unfolded.Length-k; i++)
            {
                secondFolded[i - k] = unfolded[i];
            }

            for (int i = 0; i < 2*k; i++)
            {
                summedFolds[i] = firstFolded[i] + secondFolded[i];
            }

            foreach (var item in summedFolds)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
