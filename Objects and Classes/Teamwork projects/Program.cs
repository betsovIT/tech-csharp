using System;
using System.Collections.Generic;

namespace Teamwork_projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int teamsCount = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();
            List<Team> teamsToDisband = new List<Team>();

            string input = Console.ReadLine();

            while (input != "end of assignment")
            {
                string[] info = input.Split('-');
                bool invalid = false;
                bool teamExists = false;

                // Checks conditions if someone is trying to create a team
                if (info[1][0] != '>')
                {
                    for (int i = 0; i < teams.Count; i++)
                    {
                        if (teams[i].Name == info[1])
                        {
                            Console.WriteLine($"Team {teams[i].Name} was already created!");
                            invalid = true;
                            break;
                        }
                        else if (teams[i].Creator == info[0])
                        {
                            Console.WriteLine($"{teams[i].Creator} cannot create another team!");
                            invalid = true;
                            break;
                        }
                    }
                }
                // Checks conditions if someone is trying to join a team
                else if (info[1][0] == '>')
                {
                    for (int i = 0; i < teams.Count; i++)
                    {
                        if (teams[i].Name == info[1].Substring(1))
                        {
                            teamExists = true;
                        }
                    }
                    if (teamExists)
                    {
                        for (int i = 0; i < teams.Count; i++)
                        {
                            bool foundExMem = false;

                            if (info[0] == teams[i].Creator)
                            {
                                Console.WriteLine($"Member {info[0]} cannot join team {teams[i].Name}!");
                                invalid = true;
                                break;
                            }

                            for (int j = 0; j < teams[i].Members.Count; j++)
                            {                                
                                if (info[0] == teams[i].Members[j])
                                {
                                    Console.WriteLine($"Member {info[0]} cannot join team {teams[i].Name}!");
                                    invalid = true;
                                    foundExMem = true;
                                    break;
                                }
                            }

                            if (foundExMem)
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Team {info[1].Substring(1)} does not exist!");
                        invalid = true;
                    }
                    
                    
                }

                // Check if all the requirements are met
                if (invalid)
                {
                    input = Console.ReadLine();
                    continue;
                }

                if (info[1][0] != '>')
                {
                    Team team = new Team();
                    team.Creator = info[0];
                    team.Name = info[1];
                    teams.Add(team);
                    Console.WriteLine($"Team {team.Name} has been created by {team.Creator}!");
                }
                else if (info[1][0] == '>')
                {
                    for (int i = 0; i < teams.Count; i++)
                    {
                        if (info[1].Substring(1) == teams[i].Name)
                        {
                            teams[i].Members.Add(info[0]);
                        }
                    }
                }

                input = Console.ReadLine();               
            }
            for (int i = 0; i < teams.Count; i++)
            {
                if (teams[i].Members.Count < 1)
                {
                    teamsToDisband.Add(teams[i]);
                    teams.RemoveAt(i);
                    i--;
                }
            }

            teams.Sort((x, y) => x.Members.Count.CompareTo(y.Members.Count));
            teams.Reverse();

            for (int i = 0; i < teams.Count; i++)
            {
                teams[i].Members.Sort();
            }

            teamsToDisband.Sort((x, y) => x.Name.CompareTo(y.Name));

            for (int i = 0; i < teams.Count; i++)
            {
                Console.WriteLine(teams[i].Name);
                Console.WriteLine($"- {teams[i].Creator}");
                for (int j = 0; j < teams[i].Members.Count; j++)
                {
                    Console.WriteLine($"-- {teams[i].Members[j]}");
                }
            }
            Console.WriteLine("Teams to disband:");
            for (int i = 0; i < teamsToDisband.Count; i++)
            {
                Console.WriteLine(teamsToDisband[i].Name);
            }
        }
    }
}
class Team
{
    public Team()
    {
        Members = new List<string>();
    }
    public string Name { get; set; }
    public string Creator { get; set; }
    public List<string> Members { get; set; }
}

