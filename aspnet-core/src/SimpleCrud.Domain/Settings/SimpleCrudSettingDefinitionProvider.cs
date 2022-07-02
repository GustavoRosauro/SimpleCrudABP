using Volo.Abp.Settings;

namespace SimpleCrud.Settings;

public class SimpleCrudSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(SimpleCrudSettings.MySetting1));
    }
}
