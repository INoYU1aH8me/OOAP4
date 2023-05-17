using System;
using System.Collections.Generic;


namespace OOP4
{
    class Program
    {
        static List<IFootballTeam> teams = new List<IFootballTeam>();
        static void Main(string[] args)
        {
            FillTeamList(new HumanTeamFabric(), 3);
            FillTeamList(new RobotTeamFabric(), 3);
            foreach (IFootballTeam team in teams)
            {
                PrintTeam(team);
            }
        }
        static void FillTeamList(IFootballTeamFabric teamFabric, int number)
        {
            for (int i = 0; i < number; i++)
            {
                teams.Add(teamFabric.createFootballTeam());
            }
        }
        static void PrintTeam(IFootballTeam team)
        {
            Console.WriteLine("Team Name: "+ team.GetName());
            Console.WriteLine("Members: ");            
            foreach (IFootballer player in team.GetMembers())
            {
                Console.WriteLine(player.getName() + " " + player.getNumber() + " " + player.getRole());
            }
            Console.WriteLine();
        }
    }
}
