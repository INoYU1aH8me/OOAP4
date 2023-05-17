using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    class FootballTeam : IFootballTeam
    {
        public List<IFootballer> members = new List<IFootballer>();
        public string name;

        public List<IFootballer> GetMembers()
        {
            return members;
        }

        public string GetName()
        {
            return name;
        }
    }
}
