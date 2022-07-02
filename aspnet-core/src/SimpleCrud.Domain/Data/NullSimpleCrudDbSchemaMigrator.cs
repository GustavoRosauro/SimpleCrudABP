using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace SimpleCrud.Data;

/* This is used if database provider does't define
 * ISimpleCrudDbSchemaMigrator implementation.
 */
public class NullSimpleCrudDbSchemaMigrator : ISimpleCrudDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
