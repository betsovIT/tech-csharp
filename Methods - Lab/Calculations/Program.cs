using System;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string operation = Console.ReadLine();
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            switch (operation)
            {
                case "add": Sumation(firstNumber, secondNumber);break;
                case "substract": Substraction(firstNumber, secondNumber); break;
                case "multiply": Multiplication(firstNumber, secondNumber); break;
                case "divide": Division(firstNumber, secondNumber); break;
                default:
                    break;
            }

        }

        static void Sumation(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber+secondNumber);
        }
        static void Substraction(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber-secondNumber);
        }
        static void Multiplication(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber*secondNumber);
        }
        static void Division(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber/secondNumber);
        }
    }
}
