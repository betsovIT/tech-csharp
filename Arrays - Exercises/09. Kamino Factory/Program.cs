using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthOfSequence = int.Parse(Console.ReadLine());
            int[] bestSequence = new int[lengthOfSequence];

            int seqCount = 0;

            int maxLength = 0;
            int lowestIndex = 0;
            int maxArraySum = 0;
            int bestSequenceNumber = 0;

            int sequenceLength = 0;
            int currMaxSequenceLength = 0;
            int startingIndex = 0;

            char[] separators = { '!', '?', '.' };

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Clone them!")
                {
                    break;
                }
                int[] arr = input.Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                seqCount++;
                int arraySum = arr.Sum();

                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] == arr[j + 1] && arr[j] == 1)
                    {
                        sequenceLength++;
                        if (sequenceLength > currMaxSequenceLength)
                        {
                            currMaxSequenceLength = sequenceLength;
                            startingIndex = j + 1 - sequenceLength;
                        }
                    }
                    else
                    {
                        sequenceLength = 0;
                    }
                }
                if (currMaxSequenceLength > maxLength )
                {
                    bestSequenceNumber = seqCount;
                    bestSequence = arr;
                    maxLength = currMaxSequenceLength;
                    lowestIndex = startingIndex;
                    maxArraySum = arraySum;
                }
                else if (currMaxSequenceLength == maxLength && startingIndex < lowestIndex)
                {
                    bestSequenceNumber = seqCount;
                    bestSequence = arr;
                    maxLength = currMaxSequenceLength;
                    lowestIndex = startingIndex;
                    maxArraySum = arraySum;
                }
                else if (currMaxSequenceLength == maxLength && startingIndex == lowestIndex && arraySum > maxArraySum)
                {
                    bestSequenceNumber = seqCount;
                    bestSequence = arr;
                    maxLength = currMaxSequenceLength;
                    lowestIndex = startingIndex;
                    maxArraySum = arraySum;
                }
                else if (arr.Contains(1) == false && maxArraySum == 0)
                {
                    bestSequenceNumber = seqCount;
                    bestSequence = arr;
                }
                sequenceLength = 0;
                currMaxSequenceLength = 0;
            }

            Console.WriteLine($"Best DNA sample {bestSequenceNumber} with sum: {maxArraySum}.");
            foreach (var item in bestSequence)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();


        }
    }
}

