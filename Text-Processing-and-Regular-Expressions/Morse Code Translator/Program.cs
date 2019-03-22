using System;
using System.Collections.Generic;

namespace Morse_Code_Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            var morseLibrary = new Dictionary<string, char>
            {
                {".-",'A' },
                {"-...",'B' },
                {"-.-.",'C' },
                {"-..",'D' },
                {".",'E' },
                {"..-.",'F' },
                {"--.",'G' },
                {"....",'H' },
                {"..",'I' },
                {".---",'J' },
                {"-.-",'K' },
                {".-..",'L' },
                {"--",'M' },
                {"-.",'N' },
                {"---",'O' },
                {".--.",'P' },
                {"--.-",'Q' },
                {".-.",'R' },
                {"...",'S' },
                {"-",'T' },
                {"..-",'U' },
                {"...-",'V' },
                {".--",'W' },
                {"-..-",'X' },
                {"-.--",'Y' },
                {"--..",'Z' }
            };

            for (int i = 0; i < input.Length; i++)
            {
                if (morseLibrary.ContainsKey(input[i]))
                {
                    Console.Write($"{morseLibrary[input[i]]}");
                }
                else if (input[i] == "|")
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();

        }
    }
}
