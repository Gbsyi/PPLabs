using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class PlayerFactory : IPlayerFactory
    {
        public IPlayer Create(string name)
        {
            return new Player(name);
        }
    }
}
