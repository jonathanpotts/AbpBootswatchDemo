using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace BootswatchDemo.Pages;

public class Index_Tests : BootswatchDemoWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
