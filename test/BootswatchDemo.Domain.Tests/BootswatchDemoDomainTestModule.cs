using BootswatchDemo.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace BootswatchDemo;

[DependsOn(
    typeof(BootswatchDemoEntityFrameworkCoreTestModule)
    )]
public class BootswatchDemoDomainTestModule : AbpModule
{

}
