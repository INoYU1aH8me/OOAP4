using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    class HumanTeamFabric : IFootballTeamFabric
    {
        static string[] TeamNames = new string[] { "Dinamo", "Manchester", "Spartak", "Romashka", "Slitherin" };
        static string[] Roles = new string[] { "Defender", "Semi-defender", "Attacker" };
        static Random random = new Random();        
        public IFootballTeam createFootballTeam()
        {
            FootballTeam team = new FootballTeam();
            team.name = TeamNames[random.Next(0, TeamNames.Length)];

            team.members.Add(new HumanFootballer(new Human(), "Goalkeeper", random.Next(1,30)));
            for (int i = 0; i < 10; i++)
            {
                team.members.Add(new HumanFootballer(new Human(), Roles[random.Next(0, Roles.Length)], random.Next(1, 30)));
            }
            return team;
        }

        class HumanFootballer : IFootballer
        {
            Human human;
            string role;
            int number;
            public HumanFootballer(Human human, string role, int number)
            {
                this.human = human;
                this.role = role;
                this.number = number;
            }
            public string getName()
            {
                return human.firstName + " " + human.lastName;
            }

            public string getNumber()
            {
                return number.ToString();
            }

            public string getRole()
            {
                return role;
            }
        }
    }
}
