using System;

namespace Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            var variableType = Console.ReadLine();
            var firstValue = Console.ReadLine();
            var secondValue = Console.ReadLine();

            if (int.TryParse(firstValue, out int firstIntValue) && int.TryParse(secondValue, out int secondIntValue))
            {
                Console.WriteLine(GetMax(firstIntValue, secondIntValue)); 
            }
            else if (char.TryParse(firstValue, out char firstCharValue) && char.TryParse(secondValue, out char secondCharValue))
            {
                Console.WriteLine(GetMax(firstCharValue, secondCharValue)); 
            }
            else
            {
                Console.WriteLine(GetMax(firstValue, secondValue)); 
            }
        }
        static int GetMax(int firstInt, int secondInt)
        {
            if (firstInt > secondInt)
            {
                return firstInt;
            }
            else
            {
                return secondInt;
            }
        }
        static char GetMax(char firstChar, char secondChar)
        {
            if (firstChar > secondChar)
            {
                return firstChar;
            }
            else
            {
                return secondChar;
            }
        }
        static string GetMax(string firstString, string secondString)
        {
            if (String.Compare(firstString, secondString) > 0)
            {
                return firstString;
            }
            else
            {
                return secondString;
            }
            
        }
    }
}
