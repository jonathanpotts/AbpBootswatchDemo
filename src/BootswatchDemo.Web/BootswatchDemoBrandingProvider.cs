using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace BootswatchDemo.Web;

[Dependency(ReplaceServices = true)]
public class BootswatchDemoBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "BootswatchDemo";
}
