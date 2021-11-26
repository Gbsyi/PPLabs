using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_LoggerSingleton
{
    public class Startup : BackgroundService
    {
        private readonly ILogger _logger;
        public Startup(ILogger logger)
        {
            _logger = logger;
            logger.SetLogFileName("log.txt");
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.Log("Task Started");
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
