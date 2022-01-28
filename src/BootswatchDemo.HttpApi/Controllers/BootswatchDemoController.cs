using BootswatchDemo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace BootswatchDemo.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class BootswatchDemoController : AbpControllerBase
{
    protected BootswatchDemoController()
    {
        LocalizationResource = typeof(BootswatchDemoResource);
    }
}
