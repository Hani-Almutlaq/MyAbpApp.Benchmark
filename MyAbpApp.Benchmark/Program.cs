using BenchmarkDotNet.Running;
using MyAbpApp.Benchmark.Config;
using MyAbpApp.Benchmark.EntityFrameworkCore.DemoBenchmark;

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
            BenchmarkRunner.Run<DemoRepositoryBenchmark>();

            // Stop the host
            await host.StopAsync();
        }
    }
}
