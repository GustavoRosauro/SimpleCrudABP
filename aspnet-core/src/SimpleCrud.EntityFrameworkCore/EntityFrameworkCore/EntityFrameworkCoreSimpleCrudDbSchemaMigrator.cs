using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SimpleCrud.Data;
using Volo.Abp.DependencyInjection;

namespace SimpleCrud.EntityFrameworkCore;

public class EntityFrameworkCoreSimpleCrudDbSchemaMigrator
    : ISimpleCrudDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreSimpleCrudDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the SimpleCrudDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<SimpleCrudDbContext>()
            .Database
            .MigrateAsync();
    }
}
