using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyLogger
{
    public class Logger
    {
        private ILogger _logger;
        public void SetStrategy(ILogger logger)
        {
            _logger = logger;
        }
        public void LogMessage(string message) =>
            _logger.Write(message);
        

    }
}
