using Volo.Abp.Settings;

namespace BootswatchDemo.Settings;

public class BootswatchDemoSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(BootswatchDemoSettings.MySetting1));
    }
}
