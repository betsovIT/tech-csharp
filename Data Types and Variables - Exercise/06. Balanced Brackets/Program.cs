using System;

namespace _06._Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            byte lines = byte.Parse(Console.ReadLine());

            byte openingCounter = 0;
            byte closingCounter = 0;

            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();

                if (input[0] == '(')
                {
                    openingCounter++;
                }
                else if (input[0] == ')')
                {
                    closingCounter++;
                }

                if (Math.Abs(openingCounter-closingCounter) > 1)
                {
                    break;
                    Console.WriteLine("UNBALANCED");
                }
            }

            if (Math.Abs(openingCounter - closingCounter) < 1)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
