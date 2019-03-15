using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            var participants = new Dictionary<string, int>();
            var submissions = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "exam finished")
            {
                string[] command = input.Split('-');

                if (command[1] == "banned")
                {
                    participants.Remove(command[0]);
                }            
                else if (participants.ContainsKey(command[0]) && participants[command[0]] >= int.Parse(command[2]))
                {
                    if (!submissions.ContainsKey(command[1]))
                    {
                        submissions.Add(command[1], 0);
                    }
                    submissions[command[1]]++;
                }
                else if (participants.ContainsKey(command[0]) && participants[command[0]] < int.Parse(command[2]))
                {
                    participants[command[0]] = int.Parse(command[2]);

                    if (!submissions.ContainsKey(command[1]))
                    {
                        submissions.Add(command[1], 0);
                    }
                    submissions[command[1]]++;
                }
                else
                {
                    participants.Add(command[0], int.Parse(command[2]));
                    if (!submissions.ContainsKey(command[1]))
                    {
                        submissions.Add(command[1], 0);
                    }
                    submissions[command[1]]++;
                }


                input = Console.ReadLine();
            }

            var participantsSorted = participants.OrderByDescending(n => n.Value).ThenBy(n => n.Key);
            var submissionsSorted = submissions.OrderByDescending(n => n.Value).ThenBy(n => n.Key);

            Console.WriteLine("Results:");
            foreach (var participant in participantsSorted)
            {
                Console.WriteLine($"{participant.Key} | {participant.Value}");
            }
            Console.WriteLine("Submissions:");
            foreach (var submission in submissionsSorted)
            {
                Console.WriteLine($"{submission.Key} - {submission.Value}");
            }
        }
    }
}
