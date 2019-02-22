using System;
using System.Linq;

namespace Array_Sequence_Analysis
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split("!").Select(int.Parse).ToArray();

            int sequenceLength = 0;
            int currMaxSequenceLength = 0;
            int lowerstStartingIndex = 0;

            for (int j = 0; j < arr.Length-1; j++)
            {
                if (arr[j] == arr[j + 1] && arr[j] == 1)
                {
                    sequenceLength++;
                    if (sequenceLength > currMaxSequenceLength)
                    {
                        currMaxSequenceLength = sequenceLength;
                        lowerstStartingIndex = j + 1 - sequenceLength;
                    }
                }
                else
                {
                    sequenceLength = 0;
                }
            }
            Console.WriteLine($"Max length: {currMaxSequenceLength}");
            Console.WriteLine($"Index of max sequence: {lowerstStartingIndex}");
        }
    }
}
