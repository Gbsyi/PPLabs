using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class TeamFactory : ITeamFatory
    {
        public ITeam Create(string name,List<Player> players)
        {
            Team newTeam = new(name);
            foreach(Player player in players)
            {
                newTeam.AddPlayer(player);
            }
            return newTeam;
        }
    }
}
