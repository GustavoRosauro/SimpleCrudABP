using SimpleCrud.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace SimpleCrud.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(SimpleCrudEntityFrameworkCoreModule),
    typeof(SimpleCrudApplicationContractsModule)
    )]
public class SimpleCrudDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
