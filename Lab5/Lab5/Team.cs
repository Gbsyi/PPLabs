using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Team : ITeam
    {
        private static int _counter = 1;
        public int Id;
        public string Name;
        public List<Player> Players { get; private set; }
        public Team(string name)
        {
            Id = _counter++;
            Name = name;
            Players = new();
        }
        public void AddPlayer(Player player)
        {
            player.PlayerTeam = this;
            Players.Add(player);
        }
        public void RemovePlayer(Player player)
        {
            if (Players.Contains(player))
            {
                player.PlayerTeam = null;
                Players.Remove(player);
            }
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
