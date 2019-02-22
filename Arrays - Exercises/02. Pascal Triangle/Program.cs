using System;

namespace _02._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] start = { 1 };
            Console.WriteLine(1);

            for (int i = 0; i < n-1; i++)
            {
                int[] end = new int[start.Length + 1];
                for (int j = 0; j < end.Length; j++)
                {
                    if (j == 0)
                    {
                        end[j] = 1;
                    }
                    else if (j == end.Length -1)
                    {
                        end[j] = 1;
                    }
                    else
                    {
                        end[j] = start[j] + start[j - 1];
                    }
                }
                Array.Resize(ref start, start.Length + 1);
                Array.Copy(end, 0, start, 0, end.Length);
                foreach (var item in end)
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();
            }
        }
    }
}
