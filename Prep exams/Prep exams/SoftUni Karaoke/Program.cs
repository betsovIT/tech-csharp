using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> participant = Console.ReadLine().Split(", ").ToList();
            List<string> songs = Console.ReadLine().Split(", ").ToList();
            List<string> awards = new List<string>();

            string input = Console.ReadLine();

            while (input != "dawn")
            {
                string[] performance = Console.ReadLine().Split(", ");

                if (participant.Contains(performance[0]) && songs.Contains(performance[1]))
                {
                    awards.Add()
                }
            }



        }
    }
}
