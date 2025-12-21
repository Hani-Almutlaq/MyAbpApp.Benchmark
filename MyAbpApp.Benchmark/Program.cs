using MyAbpApp.Benchmark.Config;

namespace MyAbpApp.Benchmark
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            // Run the host
            using var host = BenchmarkHost.BuildHost();
            await host.StartAsync();

            // Run benchmarks
            // e.g., BenchmarkRunner.Run<YourBenchmarkClass>();

            // Stop the host
            await host.StopAsync();
        }
    }
}
