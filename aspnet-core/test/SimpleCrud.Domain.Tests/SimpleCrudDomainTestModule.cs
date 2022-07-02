using SimpleCrud.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace SimpleCrud;

[DependsOn(
    typeof(SimpleCrudEntityFrameworkCoreTestModule)
    )]
public class SimpleCrudDomainTestModule : AbpModule
{

}
