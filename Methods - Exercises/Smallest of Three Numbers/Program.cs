using System;

namespace Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReturnSmallesOfThreeNumbers(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
        }
        static int ReturnSmallesOfThreeNumbers(int num1, int num2, int num3)
        {
            if (num1 < num2 && num1 < num3)
            {
                return num1;
            }
            else if (num2 < num1 && num2 < num3)
            {
                return num2;
            }
            else
            {
                return num3;
            }
        }
    }
}
