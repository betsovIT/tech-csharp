using System;
using System.Collections.Generic;
using System.Linq;

namespace Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> indexes = Console.ReadLine().Split().Select(int.Parse).ToList();
            string str = Console.ReadLine();
            List<char> strList = new List<char>();
            string result = "";

            for (int i = 0; i < indexes.Count; i++)
            {
                indexes[i] = GetSumOfDigits(indexes[i]);
            }
            for (int i = 0; i < str.Length; i++)
            {
                strList.Add(str[i]);
            }

            for (int i = 0; i < indexes.Count; i++)
            {
                if (indexes[i] > strList.Count - 1)
                {
                    while (indexes[i] > strList.Count - 1)
                    {
                        indexes[i] -= strList.Count;
                    }
                    result += strList[indexes[i]];
                    strList.RemoveAt(indexes[i]);
                }
                else
                {
                    result += strList[indexes[i]];
                    strList.RemoveAt(indexes[i]);
                }
            }
            Console.WriteLine(result);
        }


        static int GetSumOfDigits(int num)
        {
            int digitAbs = Math.Abs(num);
            int digitSum = 0;
            while (digitAbs > 0)
            {
                int digit = digitAbs % 10;
                digitSum += digit;
                digitAbs = digitAbs / 10;
            }
            return digitSum;
        }
    }
}
