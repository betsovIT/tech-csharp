using System;

namespace _04._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            string[] inputToArray = inputString.Split();

            for (int i = inputToArray.Length - 1; i >= 0; i--)
            {
                Console.Write(inputToArray[i]+" ");
            }
            Console.WriteLine();
        }
    }
}
