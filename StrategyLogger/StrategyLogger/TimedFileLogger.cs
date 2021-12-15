using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyLogger
{
    public class TimedFileLogger : ILogger
    {
        public string Path { get; set; }
        public TimedFileLogger(string? path = "timed_log.txt")
        {
            Path = path;
        }
        public void Write(string message)
        {
            using(StreamWriter sw = new StreamWriter(Path, true))
            {
                sw.WriteLine($"{DateTime.Now}: {message}");
            }
        }
    }
}
