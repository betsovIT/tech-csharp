using System;

namespace Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseNum = double.Parse(Console.ReadLine());
            int powNum = int.Parse(Console.ReadLine());

            Console.WriteLine(MathPower(baseNum, powNum));
        }
        static double MathPower(double baseNum, int powNum)
        {
            double result = baseNum;
            for (int i = 1; i < powNum; i++)
            {
                result = result * baseNum;
            }
            return result;
        }
    }
}
