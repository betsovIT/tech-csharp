using System;

namespace Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            var str1 = input[0];
            var str2 = input[1];

            int sum = 0;

            for (int i = 0; i < Math.Min(str1.Length,str2.Length); i++)
            {
                sum += str1[i] * str2[i];
            }

            if (str1.Length > str2.Length)
            {
                for (int i = str2.Length; i < str1.Length; i++)
                {
                    sum += str1[i];
                }
            }
            else if (str1.Length < str2.Length)
            {
                for (int i = str1.Length; i < str2.Length; i++)
                {
                    sum += str2[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
