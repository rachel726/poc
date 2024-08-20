using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace poc.Pages;

public class Index_Tests : pocWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
