using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] condensed = new int[Arr.Length - 1];

            if (Arr.Length ==1)
            {
                Console.WriteLine(Arr[0]);
                return;
            }

            while (condensed.Length > 1)
            {
                condensed = new int[Arr.Length - 1];

                for (int i = 0; i < condensed.Length; i++)
                {
                    condensed[i] = Arr[i] + Arr[i + 1];
                }

                Arr = condensed;
            }

            Console.WriteLine(condensed[0]);

        }
    }
}
