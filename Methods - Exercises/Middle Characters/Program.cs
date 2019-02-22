using System;

namespace Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            ReturnMiddleCharacters(Console.ReadLine());
        }
        static void ReturnMiddleCharacters(string str)
        {
            if (str.Length % 2 == 0)
            {
                Console.Write(str[str.Length/2 - 1]);
                Console.WriteLine(str[str.Length / 2]);
            }
            else
            {
                Console.WriteLine(str[str.Length / 2]);
            }
        }
    }
}
