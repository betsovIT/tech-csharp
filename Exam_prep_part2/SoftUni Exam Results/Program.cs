using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            var userSubmissions = new Dictionary<string, Dictionary<string, int>>();
            var exams = new Dictionary<string, int>();

            while (true)
            {
                string[] input = Console.ReadLine().Split('-');

                if (input[0] == "exam finished")
                {
                    break;
                }

                string participant = input[0];

                if (input[1] != "banned")
                {
                    string language = input[1];
                    int score = int.Parse(input[2]);

                    if (!userSubmissions.ContainsKey(participant))
                    {
                        userSubmissions.Add(participant, new Dictionary<string, int>());
                    }

                    if (!userSubmissions[participant].ContainsKey(language))
                    {
                        userSubmissions[participant].Add(language, 0);
                    }

                    if (userSubmissions[participant][language] < score)
                    {
                        userSubmissions[participant][language] = score;
                    }

                    if (!exams.ContainsKey(language))
                    {
                        exams.Add(language, 0);
                    }

                    exams[language]++;
                }
                else
                {
                    userSubmissions.Remove(participant);
                }
            }

            Console.WriteLine("Results:");
            foreach (var participant in userSubmissions.OrderByDescending(n => n.Value.Values.Sum()).ThenBy(n => n.Key))
            {
                Console.WriteLine($"{participant.Key} | {participant.Value.Values.Sum()}");
            }
            Console.WriteLine("Submissions:");
            foreach (var exam in exams.OrderByDescending(n => n.Value).ThenBy(n => n.Key))
            {
                Console.WriteLine($"{exam.Key} - {exam.Value}");
            }
        }
    }
}
