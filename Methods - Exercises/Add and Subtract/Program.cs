using System;

namespace Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SubstractFromNumber(SumTwoNumbers(double.Parse(Console.ReadLine()),double.Parse(Console.ReadLine())),double.Parse(Console.ReadLine())));
        }
        static double SumTwoNumbers(double num1, double num2)
        {
            return num1 + num2;
        }
        static double SubstractFromNumber(double num3,double num4)
        {
            return num3 - num4;
        }
    }
}
