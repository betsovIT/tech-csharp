using System;
using System.Linq;

namespace Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] initialArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    Console.WriteLine("[{0}]", string.Join(", ", initialArray));
                    break;
                }
                string[] inpArr = input.Split();
                if (inpArr[0] == "exchange")
                {
                    Exchange(initialArray, int.Parse(inpArr[1]));
                }
                if (inpArr[0] == "max")
                {
                    if (inpArr[1] == "odd")
                    {
                        if (MinMaxOddEven(initialArray, inpArr[0], inpArr[1]) == -1)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(MinMaxOddEven(initialArray, inpArr[0], inpArr[1]));
                        }
                    }
                    else if (inpArr[1] == "even")
                    {
                        if (MinMaxOddEven(initialArray, inpArr[0], inpArr[1]) == -1)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(MinMaxOddEven(initialArray, inpArr[0], inpArr[1]));
                        }
                    }
                }
                if (inpArr[0] == "min")
                {
                    if (inpArr[1] == "odd")
                    {
                        if (MinMaxOddEven(initialArray, inpArr[0], inpArr[1]) == -1)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(MinMaxOddEven(initialArray, inpArr[0], inpArr[1]));
                        }
                    }
                    else if (inpArr[1] == "even")
                    {
                        if (MinMaxOddEven(initialArray, inpArr[0], inpArr[1]) == -1)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(MinMaxOddEven(initialArray, inpArr[0], inpArr[1]));
                        }
                    }
                }
                if (inpArr[0] == "first" || inpArr[0] == "last")
                {
                    FirstOrLastNumberOfOddOrEvenElements(initialArray, inpArr[0], int.Parse(inpArr[1]), inpArr[2]);
                }
            }
        }
        static void Exchange(int[] array, int index)
        {
            if (index > array.Length - 1 || index < 0)
            {
                Console.WriteLine("Invalid index");
                return;
            }
            else
            {
                int[] firstSplit = new int[index + 1];
                int[] secondSplit = new int[array.Length - 1 - index];

                for (int i = 0; i < index + 1; i++)
                {
                    firstSplit[i] = array[i];
                }

                for (int i = 0; i < array.Length - 1 - index; i++)
                {
                    secondSplit[i] = array[i + index + 1];
                }

                for (int i = 0; i < secondSplit.Length; i++)
                {
                    array[i] = secondSplit[i];
                }
                for (int i = 0; i < firstSplit.Length; i++)
                {
                    array[secondSplit.Length + i] = firstSplit[i];
                }
            }
        }
        static int MinMaxOddEven(int[] array, string minMax, string oddEven)
        {
            int minOddIndex = -1;
            int maxOddIndex = -1;
            int minEvenIndex = -1;
            int maxEvenIndex = -1;

            int minOdd = int.MaxValue;
            int maxOdd = int.MinValue;
            int minEven = int.MaxValue;
            int maxEven = int.MinValue;

            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] % 2 != 0 && array[i] < minOdd)
                {
                    minOdd = array[i];
                    minOddIndex = i;
                }
                if (array[i] % 2 != 0 && array[i] > maxOdd)
                {
                    maxOdd = array[i];
                    maxOddIndex = i;
                }
                if (array[i] % 2 == 0 && array[i] < minEven)
                {
                    minEven = array[i];
                    minEvenIndex = i;
                }
                if (array[i] % 2 == 0 && array[i] > maxEven)
                {
                    maxEven = array[i];
                    maxEvenIndex = i;
                }
            }

            if (minMax == "min")
            {
                if (oddEven == "odd")
                {
                    return minOddIndex;
                }
                else if (oddEven == "even")
                {
                    return minEvenIndex;
                }
            }
            else if (minMax == "max")
            {
                if (oddEven == "odd")
                {
                    return maxOddIndex;
                }
                else if (oddEven == "even")
                {
                    return maxEvenIndex;
                }
            }
            return -1;
        }
        static void FirstOrLastNumberOfOddOrEvenElements(int[] array, string firstOrLast, int numberOfElements, string evenOrOdd)
        {
            if (numberOfElements > array.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            int counter = 0;
            int elCounter = 0;
            if (firstOrLast == "first")
            {
                if (evenOrOdd == "even")
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] % 2 == 0)
                        {
                            counter++;
                        }
                        if (counter == numberOfElements)
                        {
                            break;
                        }
                    }
                    int[] results = new int[counter];
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (elCounter == counter) break;
                        if (array[i] % 2 == 0)
                        {
                            results[elCounter] = array[i];
                            elCounter++;
                        }
                    }
                    Console.WriteLine("[{0}]", string.Join(", ", results));
                }
                if (evenOrOdd == "odd")
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] % 2 != 0)
                        {
                            counter++;
                        }
                        if (counter == numberOfElements)
                        {
                            break;
                        }
                    }
                    int[] results = new int[counter];
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (elCounter == counter) break;
                        if (array[i] % 2 != 0)
                        {
                            results[elCounter] = array[i];
                            elCounter++;
                        }
                    }
                    Console.WriteLine("[{0}]", string.Join(", ", results));
                }
            }
            if (firstOrLast == "last")
            {
                if (evenOrOdd == "even")
                {
                    for (int i = array.Length-1; i >= 0; i--)
                    {
                        if (array[i] % 2 == 0)
                        {
                            counter++;
                        }
                        if (counter == numberOfElements)
                        {
                            break;
                        }
                    }
                    int[] results = new int[counter];
                    for (int i = array.Length - 1; i >= 0; i--)
                    {
                        if (elCounter == counter) break;
                        if (array[i] % 2 == 0)
                        {
                            results[elCounter] = array[i];
                            elCounter++;
                        }
                    }
                    Array.Reverse(results);
                    Console.WriteLine("[{0}]", string.Join(", ", results));
                }
                if (evenOrOdd == "odd")
                {
                    for (int i = array.Length - 1; i >= 0; i--)
                    {
                        if (array[i] % 2 != 0)
                        {
                            counter++;
                        }
                        if (counter == numberOfElements)
                        {
                            break;
                        }
                    }
                    int[] results = new int[counter];
                    for (int i = array.Length - 1; i >= 0; i--)
                    {
                        if (elCounter == counter) break;
                        if (array[i] % 2 != 0)
                        {
                            results[elCounter] = array[i];
                            elCounter++;
                        }
                    }
                    Array.Reverse(results);
                    Console.WriteLine("[{0}]", string.Join(", ", results));
                }
            }
        }
    }
}