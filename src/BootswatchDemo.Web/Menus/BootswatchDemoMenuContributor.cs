using System.Threading.Tasks;
using BootswatchDemo.Localization;
using BootswatchDemo.MultiTenancy;
using Volo.Abp.Identity.Web.Navigation;
using Volo.Abp.SettingManagement.Web.Navigation;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;

namespace BootswatchDemo.Web.Menus;

public class BootswatchDemoMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var administration = context.Menu.GetAdministration();
        var l = context.GetLocalizer<BootswatchDemoResource>();

        context.Menu.Items.Insert(
            0,
            new ApplicationMenuItem(
                BootswatchDemoMenus.Home,
                l["Menu:Home"],
                "~/",
                icon: "fas fa-home",
                order: 0
            )
        );

        var themesMenu = new ApplicationMenuItem(
            "Themes",
            l["Menu:Themes"],
            icon: "fas fa-paint-brush");

        (string, LocalizedString)[] themes = new[]
        {
            ( "darkly", l["Menu:Themes:Darkly"] ),
            ( "flatly", l["Menu:Themes:Flatly"] ),
            ( "vapor", l["Menu:Themes:Vapor"] )
        };

        var httpContext = context.ServiceProvider.GetService<IHttpContextAccessor>().HttpContext;
        
        if (!httpContext.Request.Cookies.TryGetValue(BootswatchDemoWebConsts.ThemeCookie, out var theme))
        {
            theme = BootswatchDemoWebConsts.DefaultTheme;
        }

        foreach (var (name, displayName) in themes)
        {
            themesMenu.AddItem(new ApplicationMenuItem(
                name,
                displayName,
                url: $"~/Theme?theme={name}&returnUrl={httpContext.Request.Path}",
                cssClass: theme == name ? "active" : null));
        }

        context.Menu.Items.Add(themesMenu);

        if (MultiTenancyConsts.IsEnabled)
        {
            administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
        }
        else
        {
            administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
        }

        administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
        administration.SetSubItemOrder(SettingManagementMenuNames.GroupName, 3);
    }
}
