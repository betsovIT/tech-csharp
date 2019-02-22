using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_Sign
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            if (num1 == 0 || num2 == 0 || num3 == 0)
            {
                Console.WriteLine("zero");
                return;
            }

            int[] numArray = { num1, num2, num3 };
            int negativeSigns = 0;

            for (int i = 0; i < numArray.Length; i++)
            {
                if (Math.Sign(numArray[i]) == -1)
                {
                    negativeSigns++;
                }
            }

            if (negativeSigns == 0 || negativeSigns == 2)
            {
                Console.WriteLine("positive");
            }
            else if (negativeSigns == 1 || negativeSigns == 3)
            {
                Console.WriteLine("negative");
            }
        }
    }
}
