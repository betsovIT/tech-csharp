using System;

namespace Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] firstLine = CalculateLengthOf2DLine(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            double[] secondLine = CalculateLengthOf2DLine(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));

            if (firstLine[0] >= secondLine[0])
            {
                if (ReturnCloserCoordinatesFromAPair(firstLine[1], firstLine[2], firstLine[3], firstLine[4])[0] == firstLine[1] && ReturnCloserCoordinatesFromAPair(firstLine[1], firstLine[2], firstLine[3], firstLine[4])[1] == firstLine[2])
                {
                    Console.WriteLine($"({firstLine[1]}, {firstLine[2]})({firstLine[3]}, {firstLine[4]})");
                }
                else
                {
                    Console.WriteLine($"({firstLine[3]}, {firstLine[4]})({firstLine[1]}, {firstLine[2]})");
                }
            }
            else
            {
                if (ReturnCloserCoordinatesFromAPair(secondLine[1], secondLine[2], secondLine[3], secondLine[4])[0] == secondLine[1] && ReturnCloserCoordinatesFromAPair(secondLine[1], secondLine[2], secondLine[3], secondLine[4])[1] == secondLine[2])
                {
                    Console.WriteLine($"({secondLine[1]}, {secondLine[2]})({secondLine[3]}, {secondLine[4]})");
                }
                else
                {
                    Console.WriteLine($"({secondLine[3]}, {secondLine[4]})({secondLine[1]}, {secondLine[2]})");
                }
            }
        }
        static double[] CalculateLengthOf2DLine(double x1, double y1, double x2, double y2)
        {
            double length = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
            double[] output = { length, x1, y1, x2, y2 };
            return output;
        }
        static double[] ReturnCloserCoordinatesFromAPair(double X1, double Y1, double X2, double Y2)
        {
            double firstPairDistance = Math.Sqrt(Math.Pow(X1, 2) + Math.Pow(Y1, 2));
            double secondPairDistance = Math.Sqrt(Math.Pow(X2, 2) + Math.Pow(Y2, 2));
            if (firstPairDistance <= secondPairDistance)
            {
                double[] outputArr = { X1, Y1 };
                return outputArr;
            }
            else
            {
                double[] outputArr = { X2, Y2 };
                return outputArr;
            }
        }
    }
}
