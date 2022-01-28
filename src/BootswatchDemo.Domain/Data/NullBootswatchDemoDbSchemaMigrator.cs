using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace BootswatchDemo.Data;

/* This is used if database provider does't define
 * IBootswatchDemoDbSchemaMigrator implementation.
 */
public class NullBootswatchDemoDbSchemaMigrator : IBootswatchDemoDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
