using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            List<string> input = Console.ReadLine().Split().ToList();
            for (int i = 0; i < input.Count; i++)
            {
                numbers.Add(int.Parse(input[i]));
            }
            int originalLength = numbers.Count;

            for (int i = 0; i < originalLength / 2; i++)
            {
                numbers[i] = numbers[i] + numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
