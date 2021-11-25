namespace CacheStrategy
{
    public class Context
    {
        private ICacheStrategy _strategy;
        public Context() { }
        public Context(ICacheStrategy strategy)
        {
            _strategy = strategy;
        }
        public void SetStrategy(ICacheStrategy strategy) 
        {
            this._strategy = strategy;
        }
        public void WriteToCache(string key, string value)
        {
            Console.WriteLine($"Стратегия: { _strategy }. Операция: Запись. Ключ: { key }. Значение: { value }");
            _strategy.Write(key, value);
        }
        public string ReadFromCache(string key)
        {
            Console.WriteLine($"Стратегия: { _strategy }. Операция: Чтение. Ключ: { key }");
            return _strategy.Read(key);
        }
        public void DeleteFromCache(string key)
        {
            Console.WriteLine($"Стратегия: { _strategy }. Операция: Удаление. Ключ: { key }");
            _strategy.Delete(key);
        }
    }
}
