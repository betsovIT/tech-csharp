using System;
using System.Collections.Generic;
using System.Linq;

namespace MeTube_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var videoViews = new Dictionary<string, int[]>();
            char[] separators = { '-', ':' };

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "stats time")
                {
                    break;
                }

                if (input.Split(separators)[0] != "like" && input.Split(separators)[0] != "dislike")
                {
                    string video = input.Split(separators)[0];
                    int views = int.Parse(input.Split(separators)[1]);

                    if (!videoViews.ContainsKey(video))
                    {
                        videoViews.Add(video, new int[] { 0, 0 });
                    }

                    videoViews[video][0] += views;
                }
                else
                {
                    string command = input.Split(separators)[0];
                    string video = input.Split(separators)[1];

                    if (videoViews.ContainsKey(video))
                    {
                        if (command == "like")
                        {
                            videoViews[video][1]++;
                        }
                        else if (command == "dislike")
                        {
                            videoViews[video][1]--;
                        }
                    }
                }

            }

            string sortingRule = Console.ReadLine();

            if (sortingRule == "by views")
            {
                foreach (var video in videoViews.OrderByDescending(v => v.Value[0]))
                {
                    Console.WriteLine($"{video.Key} - {video.Value[0]} views - {video.Value[1]} likes");
                }
            }
            else if (sortingRule == "by likes")
            {
                foreach (var video in videoViews.OrderByDescending(v => v.Value[1]))
                {
                    Console.WriteLine($"{video.Key} - {video.Value[0]} views - {video.Value[1]} likes");
                }
            }
        }
    }
}
