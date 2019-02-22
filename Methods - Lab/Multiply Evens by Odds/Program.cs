using System;
using System.Text.RegularExpressions;

namespace Multiply_Evens_by_Odds
{
    class Program
    {

        static void Main(string[] args)
        {
            int inputNum = Math.Abs(int.Parse(Console.ReadLine()));
            string input = inputNum.ToString();
            Console.WriteLine(GetSumOfEven(input)*GetSumOfOdd(input));
        }
        static int GetSumOfEven(string num)
        {
            int sum = 0;
            for (int i = 1; i < num.Length; i += 2)
            {
                sum += (int)Char.GetNumericValue(num,i);
            }
            return sum;
        }
        static int GetSumOfOdd(string num)
        {
            int sum = 0;
            for (int i = 0; i < num.Length; i += 2)
            {
                sum += (int)Char.GetNumericValue(num,i);
            }
            return sum;
        }
    }

}
