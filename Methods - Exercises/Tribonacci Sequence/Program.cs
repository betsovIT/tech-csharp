using System;

namespace Tribonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            TribunacciCalculator(num);
        }
        static void TribunacciCalculator(int n)
        {
            int num1 = 1;
            int num2 = 1;
            int num3 = 2;
            if (n == 1)
            {
                Console.Write(num1); ;
            }
            else if (n == 2)
            {
                Console.Write(num2);
            }
            else if (n == 3)
            {
                Console.Write(num3);
            }
            else
            {
                Console.Write($"1 1 2 ");
                for (int i = 4; i <= n; i++)
                {
                    int aux1 = num3;
                    int aux2 = num2;
                    Console.Write($"{num1 + num2 + num3} ");
                    num3 = num3 + num2 + num1;
                    num2 = aux1;
                    num1 = aux2;
                }
                Console.WriteLine();
            }
            
        }
    }
}
