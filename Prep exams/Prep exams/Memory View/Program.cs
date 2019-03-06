using System;
using System.Linq;

namespace Memory_View
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string result = string.Empty;

            while (input != "Visual Studio crash")
            {
                result += input + " ";
                input = Console.ReadLine();
            }

            int[] memory = result.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int i = 0; i < memory.Length; i++)
            {
                int size = -1;
                int startindex = -1;
                if (memory[i] == 32656 && memory[i+1] == 19759 && memory[i+2] == 32763)
                {
                    size = memory[i + 4];
                    startindex = i + 6;
                }
                else
                {
                    continue;
                }

                for (int j = startindex; j <= startindex+size; j++)
                {
                    Console.Write((char)memory[j]);
                    if (j == startindex + size)
                    {
                        Console.WriteLine();
                    }
                }

            }
        }
    }
}
