using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Match : IMatch
    {
        private static int _counter = 1;
        public int Id;
        public DateTime Date;
        public string Location;
        public (int First, int Second) Result;
        public Team FirstTeam;
        public Team SecondTeam;
        public List<Player> Players;
        public Match(string location, DateTime date, Team first, Team second)
        {
            Id = _counter++;
            Location = location;
            Date = date;
            FirstTeam = first;
            SecondTeam = second;
            Players = new();
        }
    }
}
