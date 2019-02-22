using System;

namespace NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawNxNMatrix(int.Parse(Console.ReadLine()));
        }
        static void DrawNxNMatrix(int N)
        {
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= N; j++)
                {
                    Console.Write($"{N} ");
                }
                Console.WriteLine();
            }
        }
    }
}
