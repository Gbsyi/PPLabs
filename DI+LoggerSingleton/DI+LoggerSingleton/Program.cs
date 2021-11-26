using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DI_LoggerSingleton;

class Program
{
    static Task Main(string[] args) =>
        CreateHostBuilder(args).Build().RunAsync();

    static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureServices((_, services) =>
                services.AddHostedService<Startup>()
                    .AddSingleton<ILogger,Logger>());
}