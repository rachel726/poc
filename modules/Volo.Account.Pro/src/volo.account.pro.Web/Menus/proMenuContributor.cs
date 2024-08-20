using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace volo.account.pro.Web.Menus;

public class proMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        //Add main menu items.
        context.Menu.AddItem(new ApplicationMenuItem(proMenus.Prefix, displayName: "pro", "~/pro", icon: "fa fa-globe"));

        return Task.CompletedTask;
    }
}
