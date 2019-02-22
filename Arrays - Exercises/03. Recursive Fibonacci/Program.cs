using System;

namespace _03._Recursive_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(GetFibonaci(n));
        }

        public static int GetFibonaci(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            else
            {
                return GetFibonaci(n - 2) + GetFibonaci(n - 1);
            }
        }
    }
}
