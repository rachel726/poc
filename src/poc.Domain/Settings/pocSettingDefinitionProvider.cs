using Volo.Abp.Settings;

namespace poc.Settings;

public class pocSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(pocSettings.MySetting1));
    }
}
