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

        }
    }
}
