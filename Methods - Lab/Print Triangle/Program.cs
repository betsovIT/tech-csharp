using System;

namespace Print_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintUpperHalf(n);
            PrintLowerHalf(n);
        }

        static void PrintUpperHalf(int endNum)
        {
            for (int i = 1; i <= endNum; i++)
            {
                WriteRow(i);
                Console.WriteLine();
            }
        }
        static void PrintLowerHalf(int endNum)
        {
            for (int i = endNum - 1; i >= 1; i--)
            {
                WriteRow(i);
                Console.WriteLine();
            }
        }
        static void WriteRow(int end)
        {
            for (int i = 1; i <= end; i++)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
