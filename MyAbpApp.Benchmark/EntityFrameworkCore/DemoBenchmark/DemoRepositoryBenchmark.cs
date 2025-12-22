using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Attributes;
using MyAbpApp.Benchmark.Config;

namespace MyAbpApp.Benchmark.EntityFrameworkCore.DemoBenchmark
{
    [InProcess]
    [MemoryDiagnoser]
    [SimpleJob(RuntimeMoniker.Net90)]
    public class DemoRepositoryBenchmark
    {
        private IHost _host = null!;
        private IServiceScope _scope = null!;

        // Define your services here

        // private IMyRepository1 _repo1 = null!;
        // private IMyRepository2 _repo2 = null!;

        [GlobalSetup]
        public void GlobalSetup()
        {
            _host = BenchmarkHost.BuildHost();
            _scope = _host.Services.CreateScope();

            // Resolve your services here

            // _repo1 = _scope.ServiceProvider.GetRequiredService<IMyRepository1>();
            // _repo2 = _scope.ServiceProvider.GetRequiredService<IMyRepository2>();
        }

        [Benchmark]
        public async Task FindByName()
        {
            // Call methods your here to benchmark

            // _repo1.FindByName("Uzair");
            // await _repo1.FindByNameAsync("Adeeb");
            // _repo1.FindByName("Saad");
        }

        [GlobalCleanup]
        public void Cleanup()
        {
            _scope?.Dispose();
            _host?.Dispose();
        }
    }
}
