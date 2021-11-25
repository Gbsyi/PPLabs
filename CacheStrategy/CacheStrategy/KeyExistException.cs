using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheStrategy
{
    public class KeyExistException : Exception
    {
        public KeyExistException(string message)
            : base(message){ }
    }
}
