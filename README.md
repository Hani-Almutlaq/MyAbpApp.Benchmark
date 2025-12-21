# 📈 MyAbpApp.Benchmark
MyAbpApp.Benchmark is a small .NET benchmarking project that measures the performance of core layers in an ABP-based application using [BenchmarkDotNet](https://benchmarkdotnet.org/).

# 🔨 Tools
- .NET
- ABP
- BenchmarkDotNet

# 💡How to run your benchmarks?
Step 1: Create a benchmark file with a class (e.g., DemoRepositoryBenchmark.cs) and tag the methods you want to measure with [Benchmark] and use [GlobalSetup] / [GlobalCleanup] for setup/teardown (refer to [BenchmarkDotNet Articles](https://benchmarkdotnet.org/articles/overview.html) for more information regarding attributes).  
  
Step 2: In Program.cs add the name of your benchmark class inside BenchmarkRunner.Run<**Here**>().  

Step 3: Run the benchmark app.

•	✅ Always run in **Release** configuration •	✅ Run without **debugging** •	✅ Close other applications to reduce noise in measurements  

(It is highly recommended to refer back to [Benchmark Articles](https://benchmarkdotnet.org/articles/overview.html) to read more about BenchmarkDotNet attributes)

# 🤖 Analyze your benchmark results with Copilot!
You can have Copilot analyze your benchmark results for you. Simply run your benchmarks with this special command that saves the output to a file that Copilot can read:
```
dotnet run --project .\MyAbpApp.Benchmark.csproj -c Release | Tee-Object -FilePath .\.github\copilot-lastbenchmarkresult.md
```
This command will:
- ✨ Run your benchmarks in Release mode
- 💾 Store the results in .github/copilot-latest-benchmark-result.md
- 🤖 Make it easy for Copilot to read and analyze your performance data

# 📖 Useful Documentations
- [.NET Generic Host](https://learn.microsoft.com/en-us/dotnet/core/extensions/generic-host?tabs=appbuilder)
- [BenchmarkDotNet Articles](https://benchmarkdotnet.org/articles/overview.html)
- [Abp Docs](https://abp.io/docs/9.3/framework/fundamentals/application-startup)
