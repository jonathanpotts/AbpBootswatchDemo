using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BootswatchDemo.Data;
using Volo.Abp.DependencyInjection;

namespace BootswatchDemo.EntityFrameworkCore;

public class EntityFrameworkCoreBootswatchDemoDbSchemaMigrator
    : IBootswatchDemoDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreBootswatchDemoDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the BootswatchDemoDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<BootswatchDemoDbContext>()
            .Database
            .MigrateAsync();
    }
}
