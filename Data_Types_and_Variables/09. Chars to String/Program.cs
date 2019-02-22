using System;

namespace _09._Chars_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = Char.Parse(Console.ReadLine());
            char secondChar = Char.Parse(Console.ReadLine());
            char thirdChar = Char.Parse(Console.ReadLine());

            string result = Char.ToString(firstChar) + Char.ToString(secondChar) + Char.ToString(thirdChar);

            Console.WriteLine(result); ;
        }
    }
}
