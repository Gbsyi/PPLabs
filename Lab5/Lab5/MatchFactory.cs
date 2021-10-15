using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class MatchFactory
    {
        public IMatch Create(string location, DateTime date, Team first, Team second)
        {
            Match newMatch = new(location, date, first, second);
            foreach(Player player in first.Players)
            {
                newMatch.Players.Add(player);
            }
            foreach(Player player in second.Players)
            {
                newMatch.Players.Add(player);
            }
            return newMatch;
        }
    }
}
