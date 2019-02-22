using System;

namespace Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (TopIntegerChecker(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool TopIntegerChecker(int num)
        {
            bool isTop = false;

            int sum = 0;
            int oddCounter = 0;
            while (num > 0)
            {
                int j = num % 10;
                if (j % 2 != 0)
                {
                    oddCounter++;
                }
                sum += j;
                num = num / 10;
            }
            if (oddCounter > 0 && sum % 8 == 0)
            {
                isTop = true;
            }
            return isTop;
        }
    }
}
