using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string[] inp = Console.ReadLine().Split();

                if (inp[0] == "End")
                {
                    Console.WriteLine(string.Join(" ", numList));
                    break;
                }

                if (inp[0] == "Add")
                {
                    numList.Add(int.Parse(inp[1]));
                }
                else if (inp[0] == "Insert")
                {
                    if (int.Parse(inp[2]) > numList.Count - 1 || int.Parse(inp[2]) < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numList.Insert(int.Parse(inp[2]), int.Parse(inp[1]));
                }
                else if (inp[0] == "Remove")
                {
                    if (int.Parse(inp[1]) > numList.Count - 1 || int.Parse(inp[1]) < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numList.RemoveAt(int.Parse(inp[1]));
                }
                else if (inp[0] == "Shift")
                {
                    if (inp[1] == "right")
                    {
                        for (int i = 0; i < int.Parse(inp[2]); i++)
                        {
                            numList.Insert(0, numList[numList.Count - 1]);
                            numList.RemoveAt(numList.Count - 1);
                        }
                    }
                    else if (inp[1] == "left")
                    {
                        for (int i = 0; i < int.Parse(inp[2]); i++)
                        {
                            numList.Add(numList[0]);
                            numList.RemoveAt(0);
                        }

                    }
                }
            }
        }
    }
}
