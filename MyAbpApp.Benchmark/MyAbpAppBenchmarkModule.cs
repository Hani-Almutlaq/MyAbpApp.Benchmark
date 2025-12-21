using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Data;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;
using Volo.Abp.EntityFrameworkCore;

namespace MyAbpApp.Benchmark
{
    [DependsOn(
        // Add required ABP modules here
        typeof(AbpAutofacModule)

        // Add your app modules here
        // typeof(MyAbpAppDomainModule),
        // typeof(MyAbpAppApplicationModule),
        // typeof(MyAbpAppEntityFrameworkCoreModule)
    )]
    public class MyAbpAppBenchmarkModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var configuration = context.Services.GetConfiguration();

            // Configure EF Core to use your DB provider
            Configure<AbpDbContextOptions>(options =>
            {
                // options.UseNpgsql();
            });

            // Configure connection string
            Configure<AbpDbConnectionOptions>(options =>
            {
                options.ConnectionStrings.Default = configuration.GetConnectionString("Default");
            });
        }
    }
}
