using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chezy_Desktop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new main_window());

            int counter = 0;

            Console.Write("Flow in [m/3] :");
            double initWaterQ = double.Parse(Console.ReadLine());
            Console.Write("Absolute pipe slope :");
            double pipeSlope = double.Parse(Console.ReadLine());
            Console.Write("Manning pipe roughness :");
            double pipeRoughness = double.Parse(Console.ReadLine());
            Console.Write("Initial water depth :");
            double flowDepth = double.Parse(Console.ReadLine());
            Console.Write("Pipe diamter in [m] :");
            double pipeDiameter = double.Parse(Console.ReadLine());
            double pipeRadius = pipeDiameter / 2;
            double hydraulicRadius = CalculateHeight(flowDepth, pipeRadius);

            double calculatedQ = Math.PI * Math.Pow(pipeRadius, 2) * Math.Pow(hydraulicRadius, (1 / 6)) * Math.Sqrt(hydraulicRadius * pipeSlope) / pipeRoughness;

            while (calculatedQ < 0.95 * initWaterQ || initWaterQ * 1.05 < calculatedQ)
            {
                if (counter >= 2000)
                { break; }
                if (calculatedQ < initWaterQ)
                {
                    flowDepth += 0.001;
                    hydraulicRadius = CalculateHeight((double)flowDepth, (double)pipeRadius);
                    calculatedQ = Math.PI * Math.Pow(pipeRadius, 2) * Math.Pow(hydraulicRadius, (1 / 6)) * Math.Sqrt(hydraulicRadius * pipeSlope) / pipeRoughness;
                    counter++;
                }
                else
                {
                    flowDepth -= 0.001;
                    hydraulicRadius = CalculateHeight((double)flowDepth, (double)pipeRadius);
                    calculatedQ = Math.PI * Math.Pow(pipeRadius, 2) * Math.Pow(hydraulicRadius, (1 / 6)) * Math.Sqrt(hydraulicRadius * pipeSlope) / pipeRoughness;
                    counter++;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Pre-Hydraulic radius: {hydraulicRadius}");
            Console.WriteLine($"Calculated Q: {calculatedQ}");
            Console.WriteLine($"Water depth: {flowDepth}");

            Console.WriteLine($"Counter: {counter}");
        }

        public static double CalculateHeight(double num1, double num2)
        {
            if (num1 < num2)
            {
                double relativeWaterHeight = num1;
                double angleTheta = 2 * Math.Acos((num2 - relativeWaterHeight) / num2);
                double circularSegmentArea = Math.Pow(num2, 2) * ((angleTheta - Math.Sin(angleTheta)) / 2);
                double arcLength = num2 * angleTheta;
                double flowArea = circularSegmentArea;
                double wettedPerimeter = arcLength;
                double hydraulicRadius = flowArea / wettedPerimeter;
                return hydraulicRadius;
            }
            else
            {
                double relativeWaterHeight = 2 * num2 - num1;
                double angleTheta = 2 * Math.Acos((num2 - relativeWaterHeight) / num2);
                double circularSegmentArea = Math.Pow(num2, 2) * ((angleTheta - Math.Sin(angleTheta)) / 2);
                double arcLength = num2 * angleTheta;
                double flowArea = Math.PI * Math.Pow(num2, 2) - circularSegmentArea;
                double wettedPerimeter = 2 * Math.PI * num2 - arcLength;
                double hydraulicRadius = flowArea / wettedPerimeter;
                return hydraulicRadius;
            }
        }
    }
}
