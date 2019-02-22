using System;

namespace _01._Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());


            int[] numArray = new int[3] { firstNum, secondNum, thirdNum };

            Array.Sort(numArray);
            Array.Reverse(numArray);
            foreach (int j in numArray)
            {
                Console.WriteLine(j);
            }

        }
    }
}
