using AdsPortal.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AdsPortal.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AdsPortalController : AbpControllerBase
{
    protected AdsPortalController()
    {
        LocalizationResource = typeof(AdsPortalResource);
    }
}
