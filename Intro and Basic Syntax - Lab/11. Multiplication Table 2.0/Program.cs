using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (b <= 10)
            {
                for (int i = b; i <= 10; i++)
                {
                    Console.WriteLine($"{n} X {i} = {i * n}");
                }
            }
            else
            {
                Console.WriteLine($"{n} X {b} = {b * n}");
            }
            
        }
    }
}
