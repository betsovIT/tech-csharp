using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numberOfKegs = byte.Parse(Console.ReadLine());
            string bigestKeg = "";
            decimal maxVolume = decimal.MinValue;


            for (int i = 0; i < numberOfKegs; i++)
            {
                string kegModel = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                decimal volume = (decimal)(Math.PI*radius*radius*height);

                if (volume > maxVolume)
                {
                    bigestKeg = kegModel;
                    maxVolume = volume;
                }
            }

            Console.WriteLine(bigestKeg);

        }
    }
}
