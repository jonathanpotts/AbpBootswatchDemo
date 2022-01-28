using System;
using System.Collections.Generic;
using System.Text;
using BootswatchDemo.Localization;
using Volo.Abp.Application.Services;

namespace BootswatchDemo;

/* Inherit your application services from this class.
 */
public abstract class BootswatchDemoAppService : ApplicationService
{
    protected BootswatchDemoAppService()
    {
        LocalizationResource = typeof(BootswatchDemoResource);
    }
}
