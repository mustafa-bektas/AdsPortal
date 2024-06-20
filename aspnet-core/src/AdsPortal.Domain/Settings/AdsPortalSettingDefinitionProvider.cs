using Volo.Abp.Settings;

namespace AdsPortal.Settings;

public class AdsPortalSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AdsPortalSettings.MySetting1));
    }
}
