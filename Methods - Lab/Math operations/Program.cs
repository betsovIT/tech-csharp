using System;

namespace Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            double secondNum = int.Parse(Console.ReadLine());

            Console.WriteLine(PerfromAritmeticOperation(firstNum,operation,secondNum));
        }
        static double PerfromAritmeticOperation(double firstNum, char operation, double secondNum)
        {
            switch (operation)
            {
                case '+': return firstNum + secondNum;
                case '-': return firstNum - secondNum;
                case '*': return firstNum * secondNum;
                case '/': return firstNum / secondNum;
                default: return -1;
                    break;
            }
        }
    }
}
