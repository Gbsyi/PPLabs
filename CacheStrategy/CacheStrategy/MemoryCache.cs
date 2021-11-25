using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheStrategy
{
    public class MemoryCache : ICacheStrategy
    {
        private Dictionary<string, string> _cache = new Dictionary<string, string>();
        public void Delete(string key)
        {
            _cache.Remove(key);
        }

        public string Read(string key)
        {
            return _cache[key];
        }

        public void Write(string key, string value)
        {
            if (_cache.ContainsKey(key))
            {
                _cache[key] = value;
            }
            else
            {
                _cache.Add(key, value);
            }
        }
    }
}
