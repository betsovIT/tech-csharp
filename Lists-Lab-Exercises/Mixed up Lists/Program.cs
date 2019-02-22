using System;
using System.Collections.Generic;
using System.Linq;

namespace Mixed_up_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> range = new List<int>();
            List<int> mixedList = new List<int>();
            List<int> sortedResult = new List<int>();

            for (int i = 0; i < Math.Min(firstList.Count,secondList.Count); i++)
            {
                mixedList.Add(firstList[i]);
                mixedList.Add(secondList[secondList.Count-1-i]);
            }
            if (firstList.Count > secondList.Count)
            {
                range.Add(firstList[firstList.Count - 1]);
                range.Add(firstList[firstList.Count - 2]);
            }
            else
            {
                range.Add(secondList[0]);
                range.Add(secondList[1]);
            }

            for (int i = 0; i < mixedList.Count; i++)
            {
                if (mixedList[i] > Math.Min(range[0],range[1]) && mixedList[i] < Math.Max(range[0], range[1]))
                {
                    sortedResult.Add(mixedList[i]);
                }
            }
            sortedResult.Sort();
            Console.WriteLine(string.Join(" ", sortedResult));
        }
    }
}
