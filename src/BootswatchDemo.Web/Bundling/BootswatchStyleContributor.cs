using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace BootswatchDemo.Web.Bundling
{
    public class BootswatchStyleContributor : BundleContributor
    {
        public override void ConfigureBundle(BundleConfigurationContext context)
        {
            var httpContext = context.ServiceProvider.GetService<IHttpContextAccessor>().HttpContext;
            
            if (!httpContext.Request.Cookies.TryGetValue(BootswatchDemoWebConsts.ThemeCookie, out var theme))
            {
                theme = BootswatchDemoWebConsts.DefaultTheme;
            }

            context.Files.ReplaceOne(
                "/libs/bootstrap/css/bootstrap.css",
                $"/libs/bootswatch/{theme}/bootstrap.css"
            );
        }
    }
}
