using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace NewModule.Web.Menus;

public class NewModuleMenuContributor : IMenuContributor
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
        context.Menu.AddItem(new ApplicationMenuItem(NewModuleMenus.Prefix, displayName: "NewModule", "~/NewModule", icon: "fa fa-globe"));

        return Task.CompletedTask;
    }
}
