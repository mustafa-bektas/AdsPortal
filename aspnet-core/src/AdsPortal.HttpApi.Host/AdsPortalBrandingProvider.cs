using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AdsPortal;

[Dependency(ReplaceServices = true)]
public class AdsPortalBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "AdsPortal";
}
