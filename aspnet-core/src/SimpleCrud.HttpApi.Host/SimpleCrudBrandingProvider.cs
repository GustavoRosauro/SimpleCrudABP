using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace SimpleCrud;

[Dependency(ReplaceServices = true)]
public class SimpleCrudBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "SimpleCrud";
}
