using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordToRemove = Console.ReadLine().ToLower();
            string str = Console.ReadLine();

            int index = str.IndexOf(wordToRemove);

            while (index != -1)
            {
                str = str.Remove(index, wordToRemove.Length);
                index = str.IndexOf(wordToRemove);
            }

            Console.WriteLine(str);
        }
    }
}
