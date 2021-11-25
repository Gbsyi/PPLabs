using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheStrategy
{
    public class NullCache : ICacheStrategy
    {
        public void Delete(string key)
        {
            
        }

        public string Read(string key)
        {
            return "";
        }

        public void Write(string key, string value)
        {

        }
        public override string ToString()
        {
            return "NullCache";
        }
    }
}
