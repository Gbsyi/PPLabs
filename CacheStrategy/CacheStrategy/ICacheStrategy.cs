using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheStrategy
{
    public interface ICacheStrategy
    {
        public string Read(string key);
        public void Write(string key, string value);
        public void Delete(string key);
    }
}
