using System;

namespace _05._Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            string word = "";

            while (counter < n)
            {
                string input = Console.ReadLine();

                if (input == "0")
                {
                    word += ' ';
                    counter++;
                    continue;
                }

                int length = input.Length;
                int mainDigit = (int)Char.GetNumericValue(input[0]);
                int offset = (mainDigit - 2) * 3;
                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset++;
                }
                int letterIndex = offset + length - 1;
                char letter = (char)(letterIndex+97);

                word += letter;
                counter++;
            }
            Console.WriteLine(word);
            
        }
    }
}
