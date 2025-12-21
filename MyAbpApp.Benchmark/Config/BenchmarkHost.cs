using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;

namespace MyAbpApp.Benchmark.Config
{
    internal class BenchmarkHost
    {
        internal static IHost BuildHost()
        {
            return Host.CreateDefaultBuilder().ConfigureServices(services =>
            {
                services.AddApplication<MyAbpAppBenchmarkModule>();
            })
            .ConfigureLogging(logging =>
            {
                logging.ClearProviders();
                logging.SetMinimumLevel(LogLevel.Error);
            })
            .UseAutofac()
            .UseConsoleLifetime()
            .Build();
        }  
    }
}
