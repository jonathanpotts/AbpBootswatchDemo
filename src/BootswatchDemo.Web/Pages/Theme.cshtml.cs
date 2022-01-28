using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace BootswatchDemo.Web.Pages
{
    public class ThemeModel : PageModel
    {
        public void OnGet(string theme, string returnUrl = null)
        {
            var options = new CookieOptions()
            {
                Expires = DateTime.UtcNow.AddYears(10)
            };

            HttpContext.Response.Cookies.Append(BootswatchDemoWebConsts.ThemeCookie, theme, options);
            
            HttpContext.Response.Redirect(returnUrl ?? Url.Content("~/"));
        }
    }
}
