using System.Threading.Tasks;

namespace SimpleCrud.Data;

public interface ISimpleCrudDbSchemaMigrator
{
    Task MigrateAsync();
}
