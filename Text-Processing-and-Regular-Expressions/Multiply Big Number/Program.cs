using System;
using System.Collections.Generic;

namespace Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string startingNumber = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());

            if (multiplier == 0)
            {
                Console.WriteLine(0);
                return;
            }
            while (startingNumber[0] == '0')
            {
                startingNumber = startingNumber.Remove(0, 1);
            }
            List<int> listRepresentation = new List<int>();
            for (int i = 0; i < startingNumber.Length; i++)
            {
                listRepresentation.Add(int.Parse(startingNumber[i].ToString()));
            }
            for (int i = 0; i < listRepresentation.Count; i++)
            {
                listRepresentation[i] = listRepresentation[i] * multiplier;
            }

            for (int i = listRepresentation.Count - 1; i >= 0; i--)
            {
                if (listRepresentation[i] > 9 && i-1 >= 0)
                {
                    listRepresentation[i - 1] += listRepresentation[i] / 10;
                    listRepresentation[i] %= 10;
                    
                }
            }

            Console.WriteLine(string.Join("", listRepresentation));

        }
    }
}
