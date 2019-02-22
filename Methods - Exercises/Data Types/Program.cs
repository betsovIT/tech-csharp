using System;

namespace Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();
            if (dataType == "int")
            {
                Console.WriteLine(ActionDependingOnDataType(int.Parse(Console.ReadLine())));
            }
            else if (dataType == "real")
            {
                Console.WriteLine($"{ActionDependingOnDataType(double.Parse(Console.ReadLine())):F2}");
            }
            else if (dataType == "string")
            {
                Console.WriteLine(ActionDependingOnDataType(Console.ReadLine()));
            }
        }
        static int ActionDependingOnDataType(int num)
        {
            return num * 2;
        }
        static double ActionDependingOnDataType(double num)
        {
            return num * 1.5;
        }
        static string ActionDependingOnDataType(string strToPrint)
        {
            return "$"+strToPrint+"$";
        }
    }
}
