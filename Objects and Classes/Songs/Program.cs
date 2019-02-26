using System;
using System.Collections.Generic;

namespace Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numSongs = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 0; i < numSongs; i++)
            {
                string[] input = Console.ReadLine().Split('_');

                Song song = new Song();

                song.TypeList = input[0];
                song.Name = input[1];
                song.Time = input[2];

                songs.Add(song);
            }
            string typeToPrint = Console.ReadLine();

            if (typeToPrint == "all")
            {
                foreach (var item in songs)
                {
                    Console.WriteLine(item.Name);
                }
            }
            else
            {
                foreach (var item in songs)
                {
                    if (item.TypeList == typeToPrint)
                    {
                        Console.WriteLine(item.Name);
                    }
                }
            }
        }
    }
    class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
}
