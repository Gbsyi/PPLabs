using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheStrategy
{
    public class PoorManCache : ICacheStrategy
    {
        private Dictionary<string, string> _cache = new Dictionary<string,string>();
        private int _cacheLength;
        public PoorManCache(int cacheLength)
        {
            _cacheLength = cacheLength;
        }
        
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
            if(_cache.Count >= _cacheLength)
            {
                throw new Exception("Достигнут максимальный объём кэша");
            }
            else
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
}
