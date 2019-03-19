using System;

namespace Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int dotIndex = input.IndexOf('.');
            int lastBackslahIndex = input.LastIndexOf('\\');
            string fileFormat = input.Substring(dotIndex+1, input.Length -1 - dotIndex);
            string fileName = input.Substring(lastBackslahIndex + 1, dotIndex-lastBackslahIndex-1);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileFormat}");
        }
    }
}
