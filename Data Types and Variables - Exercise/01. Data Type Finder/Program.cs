using System;

namespace _01._Data_Type_Finder
{
    class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }
                long integerValue;
                char characterValue;
                bool booleanValue;
                decimal decimalValue;
                double doubleValue;
                float floatValue;

                if (long.TryParse(input, out integerValue))
                {
                    Console.WriteLine($"{integerValue} is integer type");
                    continue;
                }
                else if (decimal.TryParse(input, out decimalValue))
                {
                    Console.WriteLine($"{decimalValue} is floating point type");
                    continue;
                }
                else if (double.TryParse(input, out doubleValue))
                {
                    Console.WriteLine($"{doubleValue} is floating point type");
                    continue;
                }
                else if (float.TryParse(input, out floatValue))
                {
                    Console.WriteLine($"{floatValue} is floating point type");
                    continue;
                }
                //else if (bool.TryParse(input, out booleanValue))
                //{
                //    if (booleanValue)
                //    {
                //        Console.WriteLine($"true is boolean type");
                //        continue;
                //    }
                //    else
                //    {
                //        Console.WriteLine("false is boolean type");
                //        continue;
                //    }
                //}
                else if (input == "true" || input == "false")
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else if (char.TryParse(input, out characterValue))
                {
                    Console.WriteLine($"{characterValue} is character type");
                    continue;
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }
            }
        }
    }
}
