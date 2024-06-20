using System;
using System.Collections.Generic;
using System.Text;
using AdsPortal.Localization;
using Volo.Abp.Application.Services;

namespace AdsPortal;

/* Inherit your application services from this class.
 */
public abstract class AdsPortalAppService : ApplicationService
{
    protected AdsPortalAppService()
    {
        LocalizationResource = typeof(AdsPortalResource);
    }
}
