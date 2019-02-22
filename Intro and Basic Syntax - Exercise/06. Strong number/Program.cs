using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            int sum = 0;
            

            for (int i = n.Length - 1; i >= 0; i--)
            {
                int digit = (int)Char.GetNumericValue(n[i]);
                int partSum = 1;

                for (int j = 1; j <= digit; j++)
                {
                    
                    partSum = partSum * j;
                }

                sum += partSum;
            }

            if (int.Parse(n) == sum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
