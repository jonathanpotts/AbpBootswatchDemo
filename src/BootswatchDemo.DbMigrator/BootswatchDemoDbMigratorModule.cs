using BootswatchDemo.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace BootswatchDemo.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(BootswatchDemoEntityFrameworkCoreModule),
    typeof(BootswatchDemoApplicationContractsModule)
    )]
public class BootswatchDemoDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
