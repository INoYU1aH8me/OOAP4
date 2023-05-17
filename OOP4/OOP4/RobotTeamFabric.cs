using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    class RobotTeamFabric : IFootballTeamFabric
    {        
        static string[] Roles = new string[] { "Defender", "Semi-defender", "Attacker" };
        static Random random = new Random();
        public IFootballTeam createFootballTeam()
        {
            FootballTeam team = new FootballTeam();
            team.name = "Roboteam"+random.Next(100,1000);

            team.members.Add(new RobotFootballer(new Robot(), "Goalkeeper", random.Next(1, 30)));
            for (int i = 0; i < 10; i++)
            {
                team.members.Add(new RobotFootballer(new Robot(), Roles[random.Next(0, Roles.Length)], random.Next(1, 30)));
            }
            return team;
        }

        class RobotFootballer : IFootballer
        {
            Robot robot;
            string role;
            int number;
            public RobotFootballer(Robot robot, string role, int number)
            {
                this.robot = robot;
                this.role = role;
                this.number = number;
            }
            public string getName()
            {
                return robot.modelName+" "+robot.ID;
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
