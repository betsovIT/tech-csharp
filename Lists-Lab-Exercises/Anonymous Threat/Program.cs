using System;
using System.Collections.Generic;
using System.Linq;

namespace Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> initInput = Console.ReadLine().Split().ToList();
            List<string> manipulatedInput = initInput.ToList();

            while (true)
            {
                string inputRaw = Console.ReadLine();

                if (inputRaw == "3:1")
                {
                    Console.WriteLine(string.Join(" ", manipulatedInput));
                    break;
                }

                string[] input = inputRaw.Split(" ");

                if (input[0] == "merge")
                {
                    int startIndex = int.Parse(input[1]);
                    int endIndex = int.Parse(input[2]);

                    Merge(startIndex, endIndex, manipulatedInput);
                }
                else if (input[0] == "divide")
                {
                    int elementIndex = int.Parse(input[1]);
                    int parts = int.Parse(input[2]);

                    Divide(elementIndex, parts, manipulatedInput);
                }
            }
        }
        static void Merge(int startIndex, int endIndex, List<string> manipulatedInput)
        {
            if (manipulatedInput.Count > 0 && startIndex < manipulatedInput.Count)
            {
                string result = "";

                startIndex = Math.Max(startIndex, 0);
                endIndex = Math.Min(endIndex, manipulatedInput.Count - 1);
                int counter = 0;

                for (int i = 0; i <= endIndex-startIndex; i++)
                {
                    result += manipulatedInput[startIndex+i];
                    counter++;
                }
                manipulatedInput.RemoveRange(startIndex, counter);
                manipulatedInput.Insert(startIndex, result);

            }

        }
        static void Divide(int elementIndex, int parts, List<string> manipulatedInput)
        {
            if (elementIndex >= 0 && elementIndex < manipulatedInput.Count)
            {
                string element = manipulatedInput[elementIndex];
                int elementLength = element.Length;
                if (parts == 0)
                {
                    return;
                }
                else if (parts >= elementLength)
                {
                    for (int i = 0; i < elementLength; i++)
                    {
                        manipulatedInput.Insert(elementIndex + i, element[i].ToString());
                    }
                }
                else if (parts < elementLength)
                {
                    int wholeParts = elementLength / parts;
                    int positionCounter = 0;

                    for (int i = 0; i < parts; i++)
                    {
                        string result = "";
                        for (int j = 0; j < wholeParts; j++)
                        {
                            result += element[positionCounter];
                            positionCounter++;
                        }
                        manipulatedInput.Insert(elementIndex + i, result);
                    }
                    if (positionCounter < elementLength)
                    {
                        string finalResult = "";
                        for (int i = positionCounter; i < elementLength; i++)
                        {
                            finalResult += element[i];
                        }
                        manipulatedInput.Insert(elementIndex + parts, finalResult);
                    }                    
                }
                manipulatedInput.RemoveAt(elementIndex + parts);
            }

        }
    }
}
