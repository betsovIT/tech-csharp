using System;

namespace Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            int counter = 0;
            int startIndex = int.MaxValue;

            for (int i = 0; i < str.Length-1; i++)
            {
                if (str[i] == str[i+1])
                {
                    if (startIndex > i)
                    {
                        startIndex = i;
                    }
                    counter++;                    
                }                
                else if (counter>0)
                {
                    str = str.Remove(startIndex, counter);
                    startIndex = int.MaxValue;
                    i -= counter;
                    counter = 0;
                }

            }

            if (counter > 0)
            {
                str = str.Remove(startIndex, counter);
            }
            Console.WriteLine(str);
        }
    }
}
