using System;

namespace Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] output = ReturnCloserCoordinatesFromAPair(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            Console.WriteLine("("+string.Join(", ",output)+")"); 
        }
        static double[] ReturnCloserCoordinatesFromAPair(double X1, double Y1, double X2, double Y2)
        {
            double firstPairDistance = Math.Sqrt(Math.Pow(X1, 2) + Math.Pow(Y1, 2));
            double secondPairDistance = Math.Sqrt(Math.Pow(X2, 2) + Math.Pow(Y2, 2));
            if (firstPairDistance < secondPairDistance)
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
