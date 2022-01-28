using BootswatchDemo.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace BootswatchDemo.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class BootswatchDemoPageModel : AbpPageModel
{
    protected BootswatchDemoPageModel()
    {
        LocalizationResourceType = typeof(BootswatchDemoResource);
    }
}
