using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Attributes;
using MyAbpApp.Benchmark.Config;

namespace MyAbpApp.Benchmark.Application.DemoBenchmark
{
    [InProcess]
    [MemoryDiagnoser]
    [SimpleJob(RuntimeMoniker.Net90)]
    public class DemoAppServiceBenchmark
    {
        private IHost _host = null!;
        private IServiceScope _scope = null!;

        [GlobalSetup]
        public void GlobalSetup()
        {
            _host = BenchmarkHost.BuildHost();
            _scope = _host.Services.CreateScope();
        }

        [Benchmark]
        public void SomeMethod()
        {

        }

        [GlobalCleanup]
        public void Cleanup()
        {
            _scope?.Dispose();
            _host?.Dispose();
        }
    }
}
