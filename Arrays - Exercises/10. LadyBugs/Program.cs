using System;
using System.Linq;
namespace _10._LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fieldCondition = new int[int.Parse(Console.ReadLine())];
            int[] bugs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            for (int i = 0; i < bugs.Length; i++)
            {
                if (bugs[i] > fieldCondition.Length - 1 || bugs[i] < 0)
                {
                    continue;
                }
                fieldCondition[bugs[i]] = 1;
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }

                string[] inputArr = input.Split(' ');
                string command = inputArr[1];
                if ( int.Parse(inputArr[0]) < 0 || int.Parse(inputArr[0]) > fieldCondition.Length - 1)
                {
                    continue;
                }
                if (fieldCondition[int.Parse(inputArr[0])] != 1 )
                {
                    continue;
                }
                int[] positions = { int.Parse(inputArr[0]), int.Parse(inputArr[2]) };

                if (command == "right")
                {
                    if ((positions[0] + positions[1]) < fieldCondition.Length && (positions[0] + positions[1]) >= 0)
                    {
                        while ((positions[0] + positions[1]) < fieldCondition.Length && (positions[0] + positions[1]) >= 0)
                        {
                            if (fieldCondition[positions[0] + positions[1]] == 1)
                            {

                                positions[0] += positions[1];
                                if ((positions[0] + positions[1]) >= fieldCondition.Length)
                                {
                                    fieldCondition[int.Parse(inputArr[0])] = 0;
                                    break;
                                }

                            }
                            else
                            {
                                fieldCondition[positions[0] + positions[1]] = 1;
                                fieldCondition[int.Parse(inputArr[0])] = 0;
                                break;
                            }
                        }
                    }
                    else
                    {
                        fieldCondition[positions[0]] = 0;
                    }
                }
                else
                {
                    if ((positions[0] - positions[1]) < fieldCondition.Length && (positions[0] - positions[1]) >= 0)
                    {
                        while ((positions[0] - positions[1]) < fieldCondition.Length && (positions[0] - positions[1]) >= 0)
                        {
                            if (fieldCondition[positions[0] - (positions[1])] == 1)
                            {
                                positions[0] = positions[1];
                                if ((positions[0] - (positions[1])) < 0)
                                {
                                    fieldCondition[int.Parse(inputArr[0])] = 0;
                                    break;
                                }
                            }
                            else
                            {
                                fieldCondition[positions[0] - (positions[1])] = 1;
                                fieldCondition[int.Parse(inputArr[0])] = 0;
                                break;
                            }
                        }
                    }
                    else
                    {
                        fieldCondition[positions[0]] = 0;
                    }
                }
            }
            foreach (int item in fieldCondition)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
