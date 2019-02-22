using System;

namespace _05._Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            byte key = byte.Parse(Console.ReadLine());
            byte numberOfSymbols = byte.Parse(Console.ReadLine());
            string decripted = "";

            for (int i = 0; i < numberOfSymbols; i++)
            {
                char input = char.Parse(Console.ReadLine());
                int charRepresentation = (int)input + key;

                char decryptedChar = (char)charRepresentation;

                decripted = decripted + decryptedChar.ToString();

            }

            Console.WriteLine(decripted);
        }
    }
}
