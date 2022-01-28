using Volo.Abp.Modularity;

namespace BootswatchDemo;

[DependsOn(
    typeof(BootswatchDemoApplicationModule),
    typeof(BootswatchDemoDomainTestModule)
    )]
public class BootswatchDemoApplicationTestModule : AbpModule
{

}
