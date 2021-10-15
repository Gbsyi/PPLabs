using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Player : IPlayer
    {
        private static int _counter = 1;
        public int Id;
        public string Name;
        public Team PlayerTeam;
        public Player(string name)
        {
            Id = _counter++;
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
