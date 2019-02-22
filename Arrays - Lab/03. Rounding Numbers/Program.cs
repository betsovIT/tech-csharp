using System;

namespace _03._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] inputAsArray = input.Split();
            double[] numArray = new double[inputAsArray.Length];
            double[] roundedArray = new double[numArray.Length];

            for (int i = 0; i < inputAsArray.Length; i++)
            {
                numArray[i] = double.Parse(inputAsArray[i]);
            }

            for (int i = 0; i < numArray.Length; i++)
            {
                roundedArray[i] = Math.Round(numArray[i],MidpointRounding.AwayFromZero);
            }

            for (int i = 0; i < roundedArray.Length; i++)
            {
                Console.WriteLine($"{numArray[i]} => {roundedArray[i]}");
            }
        }
    }
}
