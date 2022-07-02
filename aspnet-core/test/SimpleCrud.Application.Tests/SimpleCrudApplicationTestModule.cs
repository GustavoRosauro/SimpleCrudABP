using Volo.Abp.Modularity;

namespace SimpleCrud;

[DependsOn(
    typeof(SimpleCrudApplicationModule),
    typeof(SimpleCrudDomainTestModule)
    )]
public class SimpleCrudApplicationTestModule : AbpModule
{

}
