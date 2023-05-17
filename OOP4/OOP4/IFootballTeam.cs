using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    interface IFootballTeam
    {
        string GetName();
        List<IFootballer> GetMembers();
    }
}
