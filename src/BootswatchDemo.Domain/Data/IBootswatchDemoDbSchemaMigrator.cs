using System.Threading.Tasks;

namespace BootswatchDemo.Data;

public interface IBootswatchDemoDbSchemaMigrator
{
    Task MigrateAsync();
}
