using System;
using System.Linq;
using System.Collections.Generic;

namespace Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> resultList = new List<int>();

            int smallerListLength = Math.Min(firstList.Count, secondList.Count);

            for (int i = 0; i < smallerListLength; i++)
            {
                resultList.Add(firstList[i]);
                resultList.Add(secondList[i]);
            }

            if (firstList.Count > secondList.Count)
            {
                for (int i = secondList.Count; i < firstList.Count; i++)
                {
                    resultList.Add(firstList[i]);
                }
            }
            else if (firstList.Count < secondList.Count)
            {
                for (int i = firstList.Count; i < secondList.Count; i++)
                {
                    resultList.Add(secondList[i]);
                }
            }

            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
